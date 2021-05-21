using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class Form1 : Form
    {
        List<Fruits> FruitsList = new List<Fruits>();
        Random randomNum=new Random();
        SqueezerForGroup1 citrusJuicer = new SqueezerForGroup1();
        SqueezerForGroup2 fruitExtractor = new SqueezerForGroup2();

        private double _totalVitaminA = 0.0;
        private double _totalVitaminC = 0.0;
        private double _totalWeight = 0.0;
        private int _time=0;
        private int _index, _lastIndex;
        private double _tempVitaminA=0.0, _tempVitaminC=0.0;

        public Form1()
        {
            InitializeComponent();
            Fruits orange = new Orange();
            Fruits grapefruit = new Grapefruit();
            Fruits mandarin = new Mandarin();
            Fruits apple = new Apple();
            Fruits pear = new Pear();
            Fruits strawberry = new Strawberry();

            List<Fruits> fruitObjects = new List<Fruits>(6) { orange, grapefruit, mandarin, apple, pear, strawberry };

            FruitsList = fruitObjects;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonContinue.Hide();
            buttonCitrus.Enabled = false;
            buttonExtractor.Enabled = false;
            buttonContinue.Enabled = false;

            timerGame.Stop();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            _time = 60;
            buttonStart.Enabled = false;
            buttonCitrus.Enabled = true;
            buttonExtractor.Enabled = true;
            buttonContinue.Enabled = true;
            timerGame.Start();

            _index = randomNum.Next(0, 6);
            _lastIndex = _index;

            if (0 <= _index && _index < 3)
            {
                FruitsList[_index].Weight = randomNum.Next(70, 121);
                FruitsList[_index].Efficiency = randomNum.Next(30, 71);
            }
            else
            {
                FruitsList[_index].Weight = randomNum.Next(70, 121);
                FruitsList[_index].Efficiency = randomNum.Next(80, 96);
            }

            _totalVitaminA = 0;
            _totalVitaminC = 0;
            _totalWeight = 0;

            fruitPictures.Image = FruitsList[_index].imageOfFruits;
            labelTime.Text = "60";
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            if (_time > 0)
            {
                _time--;
                labelTime.Text = Convert.ToString(_time);
            }
            else
            {
                timerGame.Stop();
                MessageBox.Show("Game is Over! Please Start a New Game.", "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonStart.Enabled = true;
                buttonCitrus.Enabled = false;
                buttonExtractor.Enabled = false;
                buttonContinue.Enabled = false;

                labelVitaminASum.Text = "";
                labelVitaminCSum.Text = "";
                labelTotalWeightSum.Text = "";
                labelVitaminAFruit.Text = "";
                labelVitaminCFruit.Text = "";
                labelAnswer.Text = "";
                fruitPictures.Image = null;

                buttonContinue.Hide();
                buttonCitrus.Show();
                buttonExtractor.Show();
            }
        }

        private void buttonCitrus_Click(object sender, EventArgs e)
        {
            buttonContinue.Show();
            buttonCitrus.Hide();
            buttonExtractor.Hide();

            if (0 <= _index && _index < 3)
            {
                citrusJuicer.UseSqueezerGroup1(FruitsList[_index],ref _tempVitaminA,ref _tempVitaminC, ref _totalWeight, ref _totalVitaminA, ref _totalVitaminC);
                labelAnswer.Text = "Correct!";
                labelVitaminASum.Text = String.Format("{0:0.##} (iu)", (_totalVitaminA));
                labelVitaminCSum.Text = String.Format("{0:0.##} (mg)", (_totalVitaminC));
                labelTotalWeightSum.Text = Convert.ToString(_totalWeight)+" (gr)";
                labelVitaminAFruit.Text = String.Format("{0:0.##} (iu)", (_tempVitaminA));
                labelVitaminCFruit.Text = String.Format("{0:0.##} (mg)", (_tempVitaminC));
            }
            else
            {
                labelAnswer.Text = "Incorrect!";
                labelVitaminAFruit.Text = "";
                labelVitaminCFruit.Text = "";
            }
        }

        private void buttonExtractor_Click(object sender, EventArgs e)
        {
            buttonContinue.Show();
            buttonCitrus.Hide();
            buttonExtractor.Hide();

            if (3 <= _index && _index < 6)
            {
                fruitExtractor.UseSqueezerGroup2(FruitsList[_index], ref _tempVitaminA, ref _tempVitaminC, ref _totalWeight, ref _totalVitaminA, ref _totalVitaminC);
                labelAnswer.Text = "Correct!";
                labelVitaminASum.Text = String.Format("{0:0.##} (iu)", (_totalVitaminA));
                labelVitaminCSum.Text = String.Format("{0:0.##} (mg)", (_totalVitaminC));
                labelTotalWeightSum.Text = Convert.ToString(_totalWeight) + " (gr)";
                labelVitaminAFruit.Text = String.Format("{0:0.##} (iu)", (_tempVitaminA));
                labelVitaminCFruit.Text = String.Format("{0:0.##} (mg)", (_tempVitaminC));
            }
            else
            {
                labelAnswer.Text = "Incorrect!";
                labelVitaminAFruit.Text = "";
                labelVitaminCFruit.Text = "";
            }
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            while (true)
            {
                _index = randomNum.Next(0, 6);
                if (_index != _lastIndex)
                {
                    _lastIndex = _index;
                    break;
                }
            }

            if (0 <= _index && _index < 3)
            {
                FruitsList[_index].Weight = randomNum.Next(70, 121);
                FruitsList[_index].Efficiency = randomNum.Next(30, 71);
            }
            else
            {
                FruitsList[_index].Weight = randomNum.Next(70, 121);
                FruitsList[_index].Efficiency = randomNum.Next(80, 96);
            }

            fruitPictures.Image = FruitsList[_index].imageOfFruits;

            buttonContinue.Hide();
            buttonCitrus.Show();
            buttonExtractor.Show();

            labelAnswer.Text = "";
            labelVitaminAFruit.Text = "";
            labelVitaminCFruit.Text = "";
        }
    }
}
