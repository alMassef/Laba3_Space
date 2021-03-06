﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        // поле под список (планет, звезд, комет)
        List<Spacee> spaceList = new List<Spacee>();

        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.spaceList.Clear();

            var rnd = new Random();

            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3)
                {
                    case 0: // если 0, то планета
                        this.spaceList.Add(Planet.Generate());
                        break;
                    case 1: // если 1 то звезда
                        this.spaceList.Add(Star.Generate());
                        break;
                    case 2: // если 2 то комета
                        this.spaceList.Add(Comet.Generate());
                        break;
                }
            }
            ShowInfo();
        }

        // функция выводит информацию о количестве косм объектов на форму
        private void ShowInfo()
        {
            // заведем счетчики под каждый тип
            int planetCount = 0;
            int starCount = 0;
            int cometCount = 0;
            int i = 0;

            txtTurn.Text = "Космические обьекты в очереди:\n";

            // пройдемся по всему списку
            foreach (var spase in this.spaceList)
            {
                i++;

                if (spase is Planet)
                {
                    planetCount += 1;
                    txtTurn.Text += i + ". Планета\n";

                }
                else if (spase is Star)
                {
                    starCount += 1;
                    txtTurn.Text += i + ". Звезда\n";
                }
                else if (spase is Comet)
                {
                    cometCount += 1;
                    txtTurn.Text += i + ". Комета\n";
                }
            }

            // выводим на форму
            txtInfo.Text = "Планет\tЗвезд\tКомет";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", planetCount, starCount, cometCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            // если список пуст, то напишем что пусто и выйдем из функции
            if (this.spaceList.Count == 0)
            {
                txtOut.Text = "ПУСТО!!!!!";
                return;
            }

            var space = this.spaceList[0]; // берем первый объект
            this.spaceList.RemoveAt(0); // удаляем

            // вывод информации о объекте на поле
            txtOut.Text = space.GetInfo();

            ShowInfo();
        }
    }
}
