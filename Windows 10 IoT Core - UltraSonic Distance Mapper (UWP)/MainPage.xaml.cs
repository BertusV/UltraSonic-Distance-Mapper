using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows_10_IoT_Core___UltraSonic_Distance_Mapper__UWP_.Library;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Windows_10_IoT_Core___UltraSonic_Distance_Mapper__UWP_
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Task t1 = new Task(x);
            t1.Start();
        }


        bool dir = false;
        int Objects_C = 0;
        bool Halt = true;
        public async void x()
        {
            Random Rnd = new Random(0);

            while (true)
            {
                while (Halt)
                {

                }
                await Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal,
                                        () =>
                                        {
                                            if (a1.Angle < 70 && dir == false)
                                            {
                                                a1.Angle += 0.5;
                                            }
                                            else if (a1.Angle >= 70 && dir == false)
                                            {
                                                dir = true;
                                            }

                                            if (a1.Angle > -70 && dir == true)
                                            {
                                                a1.Angle -= 0.5;
                                            }
                                            else if (a1.Angle <= -70 && dir == true)
                                            {
                                                dir = false;
                                            }



                                           // if (Rnd.Next(0, 50) == 49)
                                            {
                                                //if (Grid_Mapper.Children.Count > 140)
                                                {
                                                  //  Grid_Mapper.Children.RemoveAt(0);
                                                }
                                                if(a1.Angle==-70 || a1.Angle==70)
                                                {
                                                    Grid_Mapper.Children.Clear();
                                                }

                                                if (a1.Angle > -70 && a1.Angle < -60)
                                                {
                                                    Grid_Mapper.Children.Add(DistanceMapper.GetMapper(a1.Angle, Rnd.Next(190, 200)));
                                                }

                                                if (a1.Angle > -60 && a1.Angle < -0)
                                                {
                                                    Grid_Mapper.Children.Add(DistanceMapper.GetMapper(a1.Angle, Rnd.Next(100, 120)));
                                                }

                                                if (a1.Angle > 0 && a1.Angle < 20)
                                                {
                                                    Grid_Mapper.Children.Add(DistanceMapper.GetMapper(a1.Angle, Rnd.Next(250, 260)));
                                                }

                                                if (a1.Angle > 20 && a1.Angle < 50)
                                                {
                                                    Grid_Mapper.Children.Add(DistanceMapper.GetMapper(a1.Angle, Rnd.Next(250, 290)));
                                                }

                                                if (a1.Angle > 50 && a1.Angle < 60)
                                                {
                                                    Grid_Mapper.Children.Add(DistanceMapper.GetMapper(a1.Angle, Rnd.Next(49, 70)));
                                                }

                                                if (a1.Angle > 61 && a1.Angle < 70)
                                                {
                                                    Grid_Mapper.Children.Add(DistanceMapper.GetMapper(a1.Angle, Rnd.Next(70, 150)));
                                                }


                                            }


                                        });
                await Task.Delay(1);
            }

        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Halt = false;
        }
    }
}
