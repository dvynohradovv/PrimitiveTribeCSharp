using PrimitiveTribe1_0.ClassFolder;               
using System;                           
using System.Collections.Generic;                
using System.ComponentModel;                   
using System.Data;   
using System.Drawing;   
using System.Linq;         
using System.Text;                  
using System.Threading.Tasks;            
using System.Windows.Forms;            
using System.Media;               
using PrimitiveTribe1_0.FormsFolder;            


//Варіант 26. Створення ієрархії класів на тему «Первісне плем'я»
//Создать классы: “Человек”, и также специализированные классы по видам деятельности - “Собиратель”, “Рыбак”, “Охотник”. У человека предусмотреть набор характеристик - например, таких как физическая сила, которые влияют на успешность его профессиональной деятельности(для разных специализаций по разному). При выполнении работы соответствующие характеристики улучшаются.Также предусмотреть наличие умений, присущих всем людям - как есть, спать и т.д.
//Промоделировать взаимодействие людей в первобытном племени.


namespace PrimitiveTribe1_0
{
	public enum JobsEn { NoClassHuman, Leader, Shaman, Warrior, Hunter, Collector, Lumberjack, Fisherman, DiedHuman };
	public enum CharacteristicsEn { Strength, Agility, Intelligence, Luck };
	public enum ResourceEn { Food, Wood, Stone, AnimalSkin, TribalStrength, TribalPrestige, Medicines };
	//public enum BuildingEn { LeaderHouse, ShamanHouse, FishingBoat, Warehouse, Sawmill, Barracks, Chopping }
	//public enum State { Built, NotBuilt, BuildNow };
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			LoadInfoListViewData();
			LoadResourceInfoListData();
		}

		private Tribe tribe = new Tribe();

		private string _selectedGender_ = "man";
		private int _selectedIndex_ = -1;
		private JobsEn selectedJob = JobsEn.Leader;

		//списки, информация в них и вызов информации по штучно   
		private void LoadInfoListViewData() //Обновление списка людей
		{
			InfoListView.Items.Clear();
			foreach (var it in tribe.GetTribeListViewData()) 
			{
				ListViewItem oneItem = new ListViewItem(it); 

				InfoListView.Items.Add(oneItem); 
			}
		}      
		private void LoadResourceInfoListData()//Обновление списка ресурсов
		{
			string[] tribeResources = tribe.GetTribeResourcesData();
			FoodIndex.Text = tribeResources[0];
			WoodIndex.Text = tribeResources[1];
			StoneIndex.Text = tribeResources[2];
			AnimalSkinIndex.Text = tribeResources[3];
			MedicinesIndex.Text = tribeResources[4];

			string[] tribeSpecialInfo = tribe.GetSpecialTribeData();
			tribeStrengthLabel.Text = tribeSpecialInfo[0];
			tribePrestigeLabel.Text = tribeSpecialInfo[1];
			dayLabel.Text = tribeSpecialInfo[2];
		}    
		private void InfoListView_SelectedIndexChanged(object sender, EventArgs e) //выбор человека
		{
			CharacteristicsListView.Items.Clear();
			ListViewItem oneItem;
			if (InfoListView.SelectedItems.Count != 0)
			{
				_selectedIndex_ = Convert.ToInt32(InfoListView.FocusedItem.SubItems[0].Text);
				oneItem = new ListViewItem(tribe.GetHumanCharacteristicListViewData(_selectedIndex_));
			}
			else
			{
				_selectedIndex_ = -1;
				string[] str = { "*", "*", "*", "*", "*" };
				oneItem = new ListViewItem(str);
			}
			CharacteristicsListView.Items.Add(oneItem);
		} 
		private void InfoListView_DoubleClick(object sender, EventArgs e) //двойной щелчёк на человеке
		{
			OneHumanFullCharacteristicsForm oneHumanFullCharacteristicsForm = new OneHumanFullCharacteristicsForm();
			oneHumanFullCharacteristicsForm.LoadHumanFullInfo(tribe.GetHumanCharacteristicListViewData(_selectedIndex_), tribe.GetHumanExpData(_selectedIndex_), tribe.GetOneHumanListViewData(_selectedIndex_));

			oneHumanFullCharacteristicsForm.Show();
		} 

		//Создание нового человека
		private void GenderComboBox_SelectedIndexChanged(object sender, EventArgs e)//Селектор "выбор гендора"
		{
			_selectedGender_ = GenderComboBox.SelectedItem.ToString();
		}
		private void MakeNewHumanButton_Click_1(object sender, EventArgs e)//Кнопка "новый человек"
		{
			string message = "";
			if(tribe.MakeNoClassHuman(_selectedGender_, out message))
			{
				LoadInfoListViewData();
				LoadResourceInfoListData();
				MessageBox.Show("Поздравляю! В поселении новый житель: " + _selectedGender_);
			}
			else
			{
				MessageBox.Show("Упс. Что-то пошло не так.\n" + message);
			}
			
			
		}

		//Выбор класса
		private void ClassComboBox_SelectedIndexChanged(object sender, EventArgs e)// Селектор "выбор класса"
		{
			selectedJob = MyFunction.ParseStringToJobsEnum(ClassComboBox.SelectedItem.ToString());
		}
		private void AppointButton_Click(object sender, EventArgs e)//Кнопка "назначить на должность"
		{
			if (_selectedIndex_ != -1)
			{
				if(selectedJob == JobsEn.Leader && tribe.HasSomeClass(selectedJob))
				{
					MessageBox.Show("Вы не можете назначить больше чем одного человека на должность: " + selectedJob.ToString());
				}
				else
				{
					DialogResult result = MessageBox.Show(
						"Вы уверенны, что хотите назначить человека с индексом: '" + _selectedIndex_ + "' и с гендером: '" + tribe.GetGender(_selectedIndex_) + "' на должность: " + selectedJob.ToString(),
						"Вы уверенны?",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question,
						MessageBoxDefaultButton.Button1,
						MessageBoxOptions.ServiceNotification);
					if (result == DialogResult.Yes)
					{
						tribe.AppointTo(_selectedIndex_, selectedJob);
						//MessageBox.Show("Creating was successful");
						LoadInfoListViewData();
					}
				}
			}
			else 
			{
				MessageBox.Show("Вы никого не выбрали!");
			}
		}

		//глобальные кнопки
		private void newDayButton_Click(object sender, EventArgs e)//Кнопка "новый день"
		{
			string message;
			tribe.StartNewDay(out message);
			LoadResourceInfoListData();
			LoadInfoListViewData();
			MessageBox.Show("Начался новый день!\n" + message);
		}
	}
}
