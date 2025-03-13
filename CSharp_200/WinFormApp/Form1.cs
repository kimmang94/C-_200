using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();

            this.ClientSize = new Size(500, 500);

            Form f2 = new Form2();
            this.AddOwnedForm(f2);

            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // (1) The Simplest overload of MessageBox.Show.
            MessageBox.Show("가장 간단한 메시지박스 입니다.");

            // (2) Dialog box with text and a title
            MessageBox.Show("타이틀을 갖는 메시지 박스입니다.", "Title Message");

            // (3) Dialog box with exclamation icon
            MessageBox.Show("느낌표와 알람 메시지박스입니다.", "느낌표와 알람소리", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            // (4) Dialog box with two buttons: yes and no
            DialogResult result1 = MessageBox.Show("두 개의 버튼을 갖는 메시지박스 입니다.", "Question", MessageBoxButtons.YesNo);

            // (5) Dialog box with question icon
            DialogResult result2 = MessageBox.Show("세 개의 버튼과 물음표 아이콘을 보여주는 메시지 박스입니다.", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            // (6) Dialog box with question icon and default button.
            DialogResult result3 = MessageBox.Show("디폴드 버튼을 두 번째 버튼으로 \n지정한 메시지박스입니다.", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            string msg = string.Format("당신의 선택 : {0} {1} {2}", result3.ToString(), result2.ToString(), result3.ToString());

            // (7) 선택결과를 보여주는 메시지박스 입니다.
            MessageBox.Show(msg, "Your Selections");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("이름을 입력하세요", "Warning");
            }
            else
                label2.Text = textBox1.Text + "님! 안녕하세요!";
        }
    }
}
