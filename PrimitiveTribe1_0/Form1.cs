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


//Варіант 26. Створення ієрархії класів на тему «Первісне плем'я»
//Создать классы: “Человек”, и также специализированные классы по видам деятельности - “Собиратель”, “Рыбак”, “Охотник”. У человека предусмотреть набор характеристик - например, таких как физическая сила, которые влияют на успешность его профессиональной деятельности(для разных специализаций по разному). При выполнении работы соответствующие характеристики улучшаются.Также предусмотреть наличие умений, присущих всем людям - как есть, спать и т.д.
//Промоделировать взаимодействие людей в первобытном племени.


namespace PrimitiveTribe1_0
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			TreeNode treeNode = new TreeNode("Menu");
		}

		private Dictionary<int, Human> dic_Human = new Dictionary<int, Human>();
		private string _selectedGender_ = "man";
		private Dictionary<int, NoClassHuman> dic_NoClassHuman = new Dictionary<int, NoClassHuman>();
		private int _selectedIndex_ = 0;
		private string _selectedClass_ = "Warior";

		private void GenderListBox_SelectedIndexChanged(object sender, EventArgs e)//Селектор "выбор гендора"
		{
			_selectedGender_ = GenderListBox.SelectedItem.ToString();
		}

		private void MakeNewHumanButton_Click(object sender, EventArgs e)//Кнопка "новый человек"
		{
			dic_NoClassHuman.Add(NoClassHuman.GetIndex(), new NoClassHuman(_selectedGender_));
			MessageBox.Show("You created one: " + _selectedGender_);
		}

		private void HumanIndexNumericUpDown_ValueChanged(object sender, EventArgs e)//Селектор "выбор индекса"
		{
			_selectedIndex_ = Convert.ToInt32(HumanIndexNumericUpDown.Value);
		}

		private void ClassListBox_SelectedIndexChanged(object sender, EventArgs e)//Селектор "выбор класса"
		{
			_selectedClass_ = ClassListBox.SelectedItem.ToString();
		}

		private void AppointButton_Click(object sender, EventArgs e)//Кнопка "назначить на должность"
		{
			if (dic_NoClassHuman.ContainsKey(_selectedIndex_))
			{
				string tmp_gender = dic_NoClassHuman[_selectedIndex_].GetGender();
				switch (_selectedClass_)
				{
				case "Warrior":
				{
					dic_Human.Add(_selectedIndex_, new Warrior(tmp_gender, _selectedIndex_));
					break;
				}
				case "Hunter":
				{
					dic_Human.Add(_selectedIndex_, new Hunter(tmp_gender, _selectedIndex_));
					break;
				}
				case "Collector":
				{
					dic_Human.Add(_selectedIndex_, new Collector(tmp_gender, _selectedIndex_));
					break;
				}
				case "Lumberjack":
				{
					dic_Human.Add(_selectedIndex_, new Lumberjack(tmp_gender, _selectedIndex_));
					break;
				}
				case "Fisherman":
				{
					dic_Human.Add(_selectedIndex_, new Fisherman(tmp_gender, _selectedIndex_));
					break;
				}
				default: break;
				}
				MessageBox.Show("You appoint a human with index: " + _selectedIndex_ + " ,and with gender: " + tmp_gender + " ,to class: " + _selectedClass_);
				dic_NoClassHuman.Remove(_selectedIndex_);
			}
			else
			{
				MessageBox.Show("There is no human with index: " + _selectedIndex_);
			}
			
		}
	}
}
