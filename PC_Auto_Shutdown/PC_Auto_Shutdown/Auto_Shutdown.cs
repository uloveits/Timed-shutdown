using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Auto_Shutdown
{
	public partial class Auto_Shutdown : Form
	{
		public Auto_Shutdown()
		{
			InitializeComponent();
		}

		private void Auto_Shutdown_Load(object sender, EventArgs e)
		{
			bindCbox();
		}

		private void bindCbox()
		{

			#region 小时数据
			Dictionary<int, int> hoursDictonary = new Dictionary<int, int>();
			hoursDictonary.Add(0, 0);
			hoursDictonary.Add(1, 1);
			hoursDictonary.Add(2, 2);
			hoursDictonary.Add(3, 3);
			hoursDictonary.Add(4, 4);
			hoursDictonary.Add(5, 5);
			hoursDictonary.Add(6, 6);
			hoursDictonary.Add(7, 7);
			hoursDictonary.Add(8, 8);
			hoursDictonary.Add(9, 9);
			hoursDictonary.Add(10, 10);
			hoursDictonary.Add(11, 11);
			hoursDictonary.Add(12, 12);
			hoursDictonary.Add(13, 13);
			hoursDictonary.Add(14, 14);
			hoursDictonary.Add(15, 15);
			hoursDictonary.Add(16, 16);
			hoursDictonary.Add(17, 17);
			hoursDictonary.Add(18, 18);
			hoursDictonary.Add(19, 19);
			hoursDictonary.Add(20, 20);
			hoursDictonary.Add(21, 21);
			hoursDictonary.Add(22, 22);
			hoursDictonary.Add(23, 23);

			BindingSource bsHour = new BindingSource();
			bsHour.DataSource = hoursDictonary;
			this.hoursCombo.DataSource = bsHour;
			this.hoursCombo.ValueMember = "Key";
			this.hoursCombo.DisplayMember = "Value";
			this.hoursCombo.Text = DateTime.Now.Hour.ToString();

			#endregion

			#region 分钟数据
			Dictionary<int, String> minuteDictonary = new Dictionary<int, String>();
			minuteDictonary.Add(0, "00");
			minuteDictonary.Add(1, "01");
			minuteDictonary.Add(2, "02");
			minuteDictonary.Add(3, "03");
			minuteDictonary.Add(4, "04");
			minuteDictonary.Add(5, "05");
			minuteDictonary.Add(6, "06");
			minuteDictonary.Add(7, "07");
			minuteDictonary.Add(8, "08");
			minuteDictonary.Add(9, "09");
			minuteDictonary.Add(10, "10");
			minuteDictonary.Add(11, "11");
			minuteDictonary.Add(12, "12");
			minuteDictonary.Add(13, "13");
			minuteDictonary.Add(14, "14");
			minuteDictonary.Add(15, "15");
			minuteDictonary.Add(16, "16");
			minuteDictonary.Add(17, "17");
			minuteDictonary.Add(18, "18");
			minuteDictonary.Add(19, "19");
			minuteDictonary.Add(20, "20");
			minuteDictonary.Add(21, "21");
			minuteDictonary.Add(22, "22");
			minuteDictonary.Add(23, "23");
			minuteDictonary.Add(24, "24");
			minuteDictonary.Add(25, "25");
			minuteDictonary.Add(26, "26");
			minuteDictonary.Add(27, "27");
			minuteDictonary.Add(28, "28");
			minuteDictonary.Add(29, "29");
			minuteDictonary.Add(30, "31");
			minuteDictonary.Add(32, "32");
			minuteDictonary.Add(33, "33");
			minuteDictonary.Add(34, "34");
			minuteDictonary.Add(35, "35");
			minuteDictonary.Add(36, "36");
			minuteDictonary.Add(37, "37");
			minuteDictonary.Add(38, "38");
			minuteDictonary.Add(39, "39");
			minuteDictonary.Add(40, "40");
			minuteDictonary.Add(41, "41");
			minuteDictonary.Add(42, "42");
			minuteDictonary.Add(43, "43");
			minuteDictonary.Add(44, "44");
			minuteDictonary.Add(45, "45");
			minuteDictonary.Add(46, "46");
			minuteDictonary.Add(47, "47");
			minuteDictonary.Add(48, "48");
			minuteDictonary.Add(49, "49");
			minuteDictonary.Add(50, "50");
			minuteDictonary.Add(51, "51");
			minuteDictonary.Add(52, "52");
			minuteDictonary.Add(53, "53");
			minuteDictonary.Add(54, "54");
			minuteDictonary.Add(55, "55");
			minuteDictonary.Add(56, "56");
			minuteDictonary.Add(57, "57");
			minuteDictonary.Add(58, "58");
			minuteDictonary.Add(59, "59");

			BindingSource bsMinute = new BindingSource();
			bsMinute.DataSource = minuteDictonary;
			this.minutesCombo.DataSource = bsMinute;
			this.minutesCombo.ValueMember = "Key";
			this.minutesCombo.DisplayMember = "Value";
			this.minutesCombo.Text = DateTime.Now.Minute.ToString();

			#endregion

		}

		private void doIt_Click(object sender, EventArgs e)
		{
			DateTime nowTime = DateTime.Now;

			var shutdownTime = this.dateTime.Value.Date;
			shutdownTime = shutdownTime.AddHours(int.Parse(this.hoursCombo.Text));
			shutdownTime = shutdownTime.AddMinutes(int.Parse(this.minutesCombo.Text));

			DateTime nowTimeToDt = Convert.ToDateTime(nowTime);
			DateTime shutdownTimeToDt = Convert.ToDateTime(shutdownTime);

			

			if (shutdownTimeToDt > nowTimeToDt)
			{
				TimeSpan tsNow = new TimeSpan(nowTime.Ticks);
				TimeSpan tsShutdown = new TimeSpan(shutdownTime.Ticks);
				TimeSpan tsDiff = tsNow.Subtract(tsShutdown).Duration();
				var secondDiff = tsDiff.TotalSeconds;
				int intSecondDiff = Convert.ToInt32(secondDiff * 1.0);
				var dateDiff = tsDiff.Days.ToString() + "天" + tsDiff.Hours.ToString() + "小时" +
					tsDiff.Minutes.ToString() + "分钟" + tsDiff.Seconds.ToString() + "秒";
				var startInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe");
				startInfo.UseShellExecute = false;
				startInfo.RedirectStandardInput = true;
				startInfo.RedirectStandardOutput = true;
				startInfo.RedirectStandardError = true;
				startInfo.CreateNoWindow = true;
				var myProcess = new System.Diagnostics.Process();
				myProcess.StartInfo = startInfo;
				myProcess.Start();
				myProcess.StandardInput.WriteLine("shutdown -a ");
				myProcess.StandardInput.WriteLine("shutdown /s /f /t " + intSecondDiff);
				MessageBox.Show(string.Format("您的电脑还有{0}就要关机了！！", dateDiff));
			}
			else
			{
				MessageBox.Show("您不能选择过去的时间作为关机时间！!");
			}

		}

		private void CancelIt_Click(object sender, EventArgs e)
		{
			var startInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe");
			startInfo.UseShellExecute = false;
			startInfo.RedirectStandardInput = true;
			startInfo.RedirectStandardOutput = true;
			startInfo.RedirectStandardError = true;
			startInfo.CreateNoWindow = true;
			var myProcess = new System.Diagnostics.Process();
			myProcess.StartInfo = startInfo;
			myProcess.Start();
			myProcess.StandardInput.WriteLine("shutdown -a ");
			MessageBox.Show("您已经取消定时关机了！！");
		}
	}
}
