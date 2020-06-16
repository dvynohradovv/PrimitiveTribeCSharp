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


//Варіант 26. Створення ієрархії класів на тему «Первісне плем'я»
//Создать классы: “Человек”, и также специализированные классы по видам деятельности - “Собиратель”, “Рыбак”, “Охотник”. У человека предусмотреть набор характеристик - например, таких как физическая сила, которые влияют на успешность его профессиональной деятельности(для разных специализаций по разному). При выполнении работы соответствующие характеристики улучшаются.Также предусмотреть наличие умений, присущих всем людям - как есть, спать и т.д.
//Промоделировать взаимодействие людей в первобытном племени.


namespace PrimitiveTribe1_0
{
	public enum JobsEnum { NoClassHuman, Leader, Shaman, Fisherman, Collector, Lumberjack, Warrior, Hunter };
	public enum CharacteristicsEnum { Strength, Agility, Intelligence, Luck };
	public enum ResourceEnum { Food, Wood, Stone, AnimalSkin, TribalStrength, TribalPrestige, Medicines };
	public partial class Form1 : Form
	{
		
		public Form1()
		{
			InitializeComponent();
		}

		private Tribe tribe = new Tribe();

		private string _selectedGender_ = "man";
		private int _selectedIndex_ = -1;
		private JobsEnum selectedJob = JobsEnum.Leader;

		private void GenderComboBox_SelectedIndexChanged(object sender, EventArgs e)//Селектор "выбор гендора"
		{
			_selectedGender_ = GenderComboBox.SelectedItem.ToString();
		}
		private void MakeNewHumanButton_Click_1(object sender, EventArgs e)//Кнопка "новый человек"
		{
			tribe.MakeNoClassHuman(_selectedGender_);
			MessageBox.Show("You make a: " + _selectedGender_);
			LoadInfoListViewData();
		}
		private void LoadInfoListViewData() //Обновление списка людей
		{
			InfoListView.Items.Clear();
			foreach (var it in tribe.GetTribeListViewData())
			{
				ListViewItem oneItem = new ListViewItem(it);

				InfoListView.Items.Add(oneItem);
			}
		}
		private void LoadResourceInfoListData()
		{
			string[] str = tribe.GetTribeResourcesData();
			FoodIndex.Text = str[0];
			WoodIndex.Text = str[1];
			StoneIndex.Text = str[2];
			AnimalSkinIndex.Text = str[3];
			MedicinesIndex.Text = str[4];
		}
		private void InfoListView_SelectedIndexChanged(object sender, EventArgs e) //выделили нового человека
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
				string[] str = { "0", "0", "0", "0", "0" };
				oneItem = new ListViewItem(str);
			}
			CharacteristicsListView.Items.Add(oneItem);
		}
		private void InfoListView_DoubleClick(object sender, EventArgs e) //двойной щелчёк на человеке
		{
			
		}
		private void ClassComboBox_SelectedIndexChanged(object sender, EventArgs e)// Селектор "выбор класса"
		{
			selectedJob = MyFunction.ParseStringToJobsEnum(ClassComboBox.SelectedItem.ToString());
		}
		private void AppointButton_Click(object sender, EventArgs e)//Кнопка "назначить на должность"
		{
			if (tribe.HasHuman(_selectedIndex_))
			{
				if(selectedJob == JobsEnum.Leader && tribe.HasSomeClass(selectedJob))
				{
					MessageBox.Show("You can't select more then one: " + selectedJob.ToString());
				}
				else
				{
					DialogResult result = MessageBox.Show(
						"You appoint a human with index: '" + _selectedIndex_ + "' and with gender: '" + tribe.GetGender(_selectedIndex_) + "' to class: " + selectedJob.ToString(),
						"Are you shure?",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question,
						MessageBoxDefaultButton.Button1,
						MessageBoxOptions.ServiceNotification);
					if (result == DialogResult.Yes)
					{
						tribe.AppointTo(_selectedIndex_, selectedJob);
						MessageBox.Show("Creating was successful");
						LoadInfoListViewData();
					}
				}
			}
			else 
			{
				//MySound.ERROR.Play();
				MessageBox.Show("There is no human with index: " + _selectedIndex_);
			}
		}
		private void newDayButton_Click(object sender, EventArgs e)//Кнопка "новый день"
		{
			tribe.GoToWork();
			LoadResourceInfoListData();
			LoadInfoListViewData();
			MessageBox.Show("New day is starting!");
		}

	}
}
