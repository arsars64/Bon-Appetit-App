﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
namespace BonAppetit
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer { SoundLocation = "D:\\Vis\\проекты\\God\\WindowsFormsApp5\\assets\\s.wav" };
        bool enterHasBeenPressed = false;
        static int countOfPositions = 0;
        const int deepPlateWeight = 345;
        const int widePlateWeight = 477;
        const int verywidePlateWeight = 675;
        const int darkPlateWeight = 275;
        const int darkWidePlateWeight = 410;
        int gram;
        int intres;
        List<GramsOfFood> ListOfGrams = new List<GramsOfFood>();
        public Form1()
        {
            InitializeComponent();
            panelOfCB.BackColor = Color.Pink;
            this.BackColor = Color.Pink;
            this.KeyPreview = true;
            ListOfGrams.Add(new GramsOfFood());
            lvOfGrams.Items.Add(ToString(ListOfGrams));
            rbnoplate.Checked = true;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Escape) this.Close();
            else if (e.KeyValue == (char)Keys.Delete) ClearList();
            else if (e.KeyValue == (char)Keys.Enter)
            {
                if (intres > 0)
                {
                    enterHasBeenPressed = true;
                    countOfPositions++;
                    if (!cbCountApart.Checked)
                    {
                        GramsOfFood.sumOfGrams += ListOfGrams[ListOfGrams.Count - 1].Grams;
                        panelOfCB.Enabled = false;
                    }
                    else lvOfGrams.Items[countOfPositions - 1].BackColor = Color.LightGreen;
                    ListOfGrams.Add(new GramsOfFood());
                    lvOfGrams.Items.Add(this.ToString(ListOfGrams));
                    tbGram.Text = "";
                    tbFoodName.Text = "";
                    cbCountApart.Checked = false;
                }
            }
        }
        public void Transfer()
        {
            try
            {
                gram = Convert.ToInt32(tbGram.Text);
                if (gram == 666) PlayRun(player);
            }
            catch (FormatException)
            {
                if (tbGram.Text != "")
                {
                    MessageBox.Show("вводи число, причем положительное!");
                    tbGram.Text = "";
                    return;
                }
                if (tbGram.Text == "") gram = 0;
            }
            catch { }
            if (rbnoplate.Checked) intres = gram;
            else if (rbdeepplate.Checked) intres = (gram - deepPlateWeight) >= 0 ? gram - deepPlateWeight : 0;
            else if (rbwideplate.Checked) intres = (gram - widePlateWeight) >= 0 ? gram - widePlateWeight : 0;
            else if (rbVerywidePlate.Checked) intres = (gram - verywidePlateWeight) >= 0 ? gram - verywidePlateWeight : 0;
            else if (rbDarkPlate.Checked) intres = (gram - darkPlateWeight) >= 0 ? gram - darkPlateWeight : 0;
            else if (rbDarkWidePlate.Checked) intres = (gram - darkWidePlateWeight) >= 0 ? gram - darkWidePlateWeight : 0;

            if (cbCountApart.Checked) ListOfGrams[countOfPositions].Grams = intres;
            else ListOfGrams[countOfPositions].Grams = (intres - GramsOfFood.sumOfGrams)>=0? (intres - GramsOfFood.sumOfGrams)  : 0;
            lvOfGrams.Items.RemoveAt(countOfPositions);
            lvOfGrams.Items.Insert(countOfPositions, this.ToString(ListOfGrams));
            if (cbCountApart.Checked) lvOfGrams.Items[countOfPositions].BackColor = Color.LightGreen;
        }
        private void rbwideplate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbwideplate.Checked) Transfer();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnoplate.Checked) Transfer();
        }
        private void rbdeepplate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbdeepplate.Checked) Transfer();
        }
        private void rbVerywidePlate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVerywidePlate.Checked) Transfer();
        }
        private void rbDarkPlate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDarkPlate.Checked) Transfer();
        }
        private void rbDarkWidePlate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDarkWidePlate.Checked) Transfer();
        }
        public string ToString(List<GramsOfFood> list) => list[list.Count - 1].Grams.ToString() + " гр "
            + list[list.Count - 1].FoodName.ToString();
        private void tbGram_TextChanged(object sender, EventArgs e) => Transfer();
        private void tbFoodName_TextChanged(object sender, EventArgs e)
        {
            if (tbFoodName.Text != "")
            {
                ListOfGrams[countOfPositions].FoodName = tbFoodName.Text;
                lvOfGrams.Items.RemoveAt(countOfPositions);
                lvOfGrams.Items.Insert(countOfPositions, this.ToString(ListOfGrams));
            }
        }
        private void bClearList_Click(object sender, EventArgs e) => ClearList();
        private void ClearList()
        {
            panelOfCB.Enabled = true;
            ListOfGrams.Clear();
            ListOfGrams.Add(new GramsOfFood());
            lvOfGrams.Items.Clear();
            lvOfGrams.Items.Add(ToString(ListOfGrams));
            GramsOfFood.sumOfGrams = 0;
            countOfPositions = 0;
            tbGram.Text = "";
            tbFoodName.Text = "";
            enterHasBeenPressed = false;
        }
        private void PlayStop(SoundPlayer s)
        {
            pictureBox1.Dock = DockStyle.None;
            pictureBox1.Location = new Point(384, 0);
            this.Text = "Мой калькулятор веса еды";
            pictureBox1.Image = Image.FromFile("D:\\Vis\\проекты\\God\\WindowsFormsApp5\\assets\\BO.gif");
            this.BackgroundImage = null;
            this.BackColor = Color.Pink;
            panelOfCB.BackColor = Color.Pink;
            tbFoodName.Enabled = true;
            tbGram.Enabled = true;
            s.Stop();
        }
        private void PlayRun(SoundPlayer s)
        {
            s.Play();
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            panelOfCB.BackColor = Color.Red;
            this.BackgroundImage = Image.FromFile("D:\\Vis\\проекты\\God\\WindowsFormsApp5\\assets\\fire.gif");
            this.Text = "САТАНА!!!!!!!1";
            pictureBox1.Image = Image.FromFile("D:\\Vis\\проекты\\God\\WindowsFormsApp5\\assets\\satan.gif");
            this.BackColor = Color.Red;
            tbGram.Enabled = false;
            tbFoodName.Enabled = false;
        }
        private void cbCountApart_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCountApart.Checked) panelOfCB.Enabled = true;
            else if (enterHasBeenPressed == true) panelOfCB.Enabled = false;
            Transfer();
        }
        private void pictureBox1_Click(object sender, EventArgs e) => PlayStop(player);
    }
}
