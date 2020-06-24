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

namespace PrimitiveTribe1_0.FormsFolder
{
	public partial class OneHumanFullCharacteristicsForm : Form
	{
		public OneHumanFullCharacteristicsForm()
		{
			InitializeComponent();
		}
		public void LoadHumanFullInfo(string[] humanCharacteristics, string[] humanJobsExp, string[] OneHumanListViewData)
		{
			strengthLabel.Text = humanCharacteristics[0];
			agilityLabel.Text = humanCharacteristics[1];
			intelligenceLabel.Text = humanCharacteristics[2];
			luckLabel.Text = humanCharacteristics[3];

			leaderLabel.Text = humanJobsExp[0];
			shamanLabel.Text = humanJobsExp[1];
			warriorLabel.Text = humanJobsExp[2];
			hunterLabel.Text = humanJobsExp[3];
			collectorLabel.Text = humanJobsExp[4];
			lumberjackLabel.Text = humanJobsExp[5];
			fishermanLabel.Text = humanJobsExp[6];

			indexLabel.Text = OneHumanListViewData[0]; 
			fullnameLabel.Text = OneHumanListViewData[1];
			jobLabel.Text = OneHumanListViewData[2];
			genderLabel.Text = OneHumanListViewData[3];
		}
	}
}
