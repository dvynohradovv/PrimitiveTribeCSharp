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

			TreeNode treeNode = new TreeNode("Menu");
		}

		private Tribe tribe = new Tribe();

		private string _selectedGender_ = "man";
		private int _selectedIndex_ = 0;
		private string _selectedJobStr_ = "Leader";
		private JobsEnum selectedJob = JobsEnum.Leader;
		private void GenderComboBox_SelectedIndexChanged(object sender, EventArgs e)//Селектор "выбор гендора"
		{
			_selectedGender_ = GenderComboBox.SelectedItem.ToString();
		}
		private void MakeNewHumanButton_Click_1(object sender, EventArgs e)//Кнопка "новый человек"
		{
			tribe.MakeNoClassHuman(_selectedGender_);
			MessageBox.Show("You make a: " + _selectedGender_);
		}
		private void HumanIndexNumericUpDown_ValueChanged(object sender, EventArgs e)//Селектор "выбор индекса"
		{
			_selectedIndex_ = Convert.ToInt32(HumanIndexNumericUpDown.Value);
		}
		private void ClassComboBox_SelectedIndexChanged(object sender, EventArgs e)// Селектор "выбор класса"
		{
			_selectedJobStr_ = ClassComboBox.SelectedItem.ToString();
			selectedJob = MyFunction.ParseToJobsEnum(_selectedJobStr_);
		}
		private void AppointButton_Click(object sender, EventArgs e)//Кнопка "назначить на должность"
		{
			if (tribe.HasHuman(_selectedIndex_))
			{
				if((selectedJob == JobsEnum.Leader || selectedJob == JobsEnum.Shaman) && tribe.HasSomeClass(selectedJob))
				{
					MessageBox.Show("You can't select more then one: " + _selectedJobStr_);
				}
				else
				{
					DialogResult result = MessageBox.Show(
						"You appoint a human with index: '" + _selectedIndex_ + "' and with gender: '" + tribe.GetGender(_selectedIndex_) + "' to class: " + _selectedJobStr_,
						"Are you shure?",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question,
						MessageBoxDefaultButton.Button1,
						MessageBoxOptions.ServiceNotification);
					if (result == DialogResult.Yes)
					{
						tribe.AppointTo(_selectedIndex_, selectedJob);
						MessageBox.Show("Creating was successful");
					}
				}
			}
			else 
			{
				//MySound.ERROR.Play();
				MessageBox.Show("There is no human with index: " + _selectedIndex_);
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			tribe.GoToWork();
		}
	}
}
