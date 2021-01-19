﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace KattintósWPF
{

    public partial class MainWindow : Window
    {
        DispatcherTimer idozito = new DispatcherTimer();
        DispatcherTimer xx = new DispatcherTimer();
        int sebesseg = 3;
        int ujobject = 90;
        Random rnd = new Random();

        List<Rectangle> eltunteto = new List<Rectangle>();

        ImageBrush hatterkep = new ImageBrush();

        int textura;
        double i;
        int kihagyott;
        bool futAJatek;
        int pontszam;
        int szint = 1;
        readonly MediaPlayer jatekos = new MediaPlayer();


        public MainWindow()
        {
            InitializeComponent();
            idozito.Tick += GameEngine;
            idozito.Interval = TimeSpan.FromMilliseconds(20);
            xx.Tick += new EventHandler(dispatcherTimer_Tick);
            xx.Interval = new TimeSpan(0, 0, 10);

            hatterkep.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Files/background-Image.jpg"));
            MyCanvas.Background = hatterkep;
            Restart();
        }

        private void GameEngine(object sender, EventArgs e)
        {
            PontszamText.Content = "Pontszám: " + pontszam;
            KihagyottText.Content = "Kihagyott: " + kihagyott;
            SzintText.Content = "Szint: " + szint;
            ujobject -= 10;
            if (ujobject < 1)
            {
                ImageBrush lufi = new ImageBrush();
                textura += 1;
                if (textura > 10)
                {
                    textura = 1;
                }

                switch (textura)
                {
                    case 1:
                        lufi.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Files/balloon1.png"));
                        break;
                    case 2:
                        lufi.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Files/balloon2.png"));
                        break;
                    case 3:
                        lufi.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Files/balloon3.png"));
                        break;
                    case 4:
                        lufi.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Files/balloon4.png"));
                        break;
                    case 5:
                        lufi.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Files/balloon5.png"));
                        break;
                    case 6:
                        lufi.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Files/balloon6.png"));
                        break;
                    case 7:
                        lufi.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Files/balloon7.png"));
                        break;
                    case 8:
                        lufi.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Files/balloon8.png"));
                        break;
                    case 9:
                        lufi.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Files/balloon9.png"));
                        break;
                    case 10:
                        lufi.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Files/balloon10.png"));
                        break;
                }
                Rectangle ujlufi = new Rectangle
                {
                    Tag = "lufi",
                    Height = 70,
                    Width = 50,
                    Fill = lufi
                };
                Canvas.SetTop(ujlufi, 600);
                Canvas.SetLeft(ujlufi, rnd.Next(80, 360)); //hol jelenjen meg az új lufi, pixelek között
                MyCanvas.Children.Add(ujlufi);
                ujobject = rnd.Next(100, 200); //80 140
            }

            foreach (var x in MyCanvas.Children.OfType<Rectangle>())
            {
                if ((string)x.Tag == "lufi")
                {
                    i = rnd.Next(-5, 5);
                    Canvas.SetTop(x, Canvas.GetTop(x) - sebesseg); // felfelé mozgás
                    Canvas.SetLeft(x, Canvas.GetLeft(x) - (i * -1)); //jobbra-balra mozgás
                }


            //memóriagazdálkodás
                if (Canvas.GetTop(x) + 20 < 20)
                {
                    eltunteto.Add(x);
                    kihagyott += 1;
                }
            }

            foreach (Rectangle y in eltunteto)
            {
                MyCanvas.Children.Remove(y);
            }
            //játék vége
            if (kihagyott > 100)
            {
                futAJatek = false;
                idozito.Stop();
                xx.Stop();
                MessageBox.Show("Vége a játéknak!" + Environment.NewLine + "Kattints az OK gombra az újrakezdéshez!");
                Restart();
            }
        }

        //játék sebességének gyorsítása
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            sebesseg++;
            szint++;
        }

        private void Kattintas(object sender, MouseButtonEventArgs e)
        {
            if (futAJatek)
            {
                if (e.OriginalSource is Rectangle) // ha lufira kattintok
                {
                    Rectangle aktív = (Rectangle)e.OriginalSource;
                    jatekos.Open(new Uri("../../Files/pop_sound.mp3", UriKind.RelativeOrAbsolute));
                    jatekos.Play();

                    MyCanvas.Children.Remove(aktív); //ha eltalálom, eltünteti
                    pontszam += 1; //és növeli a pontszámot
                }
            }
        }

        private void Start()
        {
            idozito.Start();
            xx.Start();
            kihagyott = 0;
            pontszam = 0;
            ujobject = 2;
            futAJatek = true;
            sebesseg = 2;
            
        }

        private void Restart()
        {

            foreach (var x in MyCanvas.Children.OfType<Rectangle>())
            {
                eltunteto.Add(x);
            }
            foreach (Rectangle y in eltunteto)
            {
                MyCanvas.Children.Remove(y);
            }
            eltunteto.Clear();
            Start();
        }

    }
}
