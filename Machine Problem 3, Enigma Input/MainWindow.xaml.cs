using System;
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

namespace Machine_Problem_3__Enigma_Input
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool shiftPressed = false;
        bool capsLockActive = false;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            string retVal = "";

            if (e.Key == Key.CapsLock) //For Activating and Deactivationg Capslock and Changing the UI
            {
                capsLockActive = !capsLockActive;
                shiftPressed = false;
                key_button();

                if (capsLockActive == true)
                {
                    lbl_shiftlock.Background = Brushes.Red;

                    lbl_a.Content = "A";
                    lbl_b.Content = "B";
                    lbl_c.Content = "C";
                    lbl_d.Content = "D";
                    lbl_e.Content = "E";
                    lbl_f.Content = "F";
                    lbl_g.Content = "G";
                    lbl_h.Content = "H";
                    lbl_i.Content = "I";
                    lbl_j.Content = "J";
                    lbl_k.Content = "K";
                    lbl_l.Content = "L";
                    lbl_m.Content = "M";
                    lbl_n.Content = "N";
                    lbl_o.Content = "O";
                    lbl_p.Content = "P";
                    lbl_q.Content = "Q";
                    lbl_r.Content = "R";
                    lbl_s.Content = "S";
                    lbl_t.Content = "T";
                    lbl_u.Content = "U";
                    lbl_v.Content = "V";
                    lbl_w.Content = "W";
                    lbl_x.Content = "X";
                    lbl_y.Content = "Y";
                    lbl_z.Content = "Z";

                    lbl_1.Content = "!";
                    lbl_2.Content = "@";
                    lbl_3.Content = "#";
                    lbl_4.Content = "$";
                    lbl_5.Content = "%";
                    lbl_6.Content = "^";
                    lbl_7.Content = "&";
                    lbl_8.Content = "*";
                    lbl_9.Content = "(";
                    lbl_0.Content = ")";

                    lbl_spcl1.Content = "_";
                    lbl_spcl2.Content = "+";
                    lbl_spcl3.Content = "{";
                    lbl_spcl4.Content = "}";
                    lbl_spcl5.Content = "|";
                    lbl_spcl6.Content = ":";
                    lbl_spcl7.Content = '"';
                    lbl_spcl8.Content = "<";
                    lbl_spcl9.Content = ">";
                    lbl_spcl10.Content = "?";

                }
                else
                {
                    lbl_shiftlock.Background = Brushes.White;

                    lbl_a.Content = "a";
                    lbl_b.Content = "b";
                    lbl_c.Content = "c";
                    lbl_d.Content = "d";
                    lbl_e.Content = "e";
                    lbl_f.Content = "f";
                    lbl_g.Content = "g";
                    lbl_h.Content = "h";
                    lbl_i.Content = "i";
                    lbl_j.Content = "j";
                    lbl_k.Content = "k";
                    lbl_l.Content = "l";
                    lbl_m.Content = "m";
                    lbl_n.Content = "n";
                    lbl_o.Content = "o";
                    lbl_p.Content = "p";
                    lbl_q.Content = "q";
                    lbl_r.Content = "r";
                    lbl_s.Content = "s";
                    lbl_t.Content = "t";
                    lbl_u.Content = "u";
                    lbl_v.Content = "v";
                    lbl_w.Content = "w";
                    lbl_x.Content = "x";
                    lbl_y.Content = "y";
                    lbl_z.Content = "z";

                    lbl_1.Content = "1";
                    lbl_2.Content = "2";
                    lbl_3.Content = "3";
                    lbl_4.Content = "4";
                    lbl_5.Content = "5";
                    lbl_6.Content = "6";
                    lbl_7.Content = "7";
                    lbl_8.Content = "8";
                    lbl_9.Content = "9";
                    lbl_0.Content = "9";

                    lbl_spcl1.Content = "-";
                    lbl_spcl2.Content = "=";
                    lbl_spcl3.Content = "[";
                    lbl_spcl4.Content = "]";
                    lbl_spcl5.Content = '\'';
                    lbl_spcl6.Content = ";";
                    lbl_spcl7.Content = "'";
                    lbl_spcl8.Content = ",";
                    lbl_spcl9.Content = ".";
                    lbl_spcl10.Content = "/";
                }
            }

            else if (e.Key == Key.LeftShift) //For Activating and Deactivationg Shift and Changing the UI
            {
                shiftPressed = !shiftPressed;
                key_button();

                if (shiftPressed == true)
                {
                    lbl_shift.Background = Brushes.Yellow;

                    lbl_a.Content = "A";
                    lbl_b.Content = "B";
                    lbl_c.Content = "C";
                    lbl_d.Content = "D";
                    lbl_e.Content = "E";
                    lbl_f.Content = "F";
                    lbl_g.Content = "G";
                    lbl_h.Content = "H";
                    lbl_i.Content = "I";
                    lbl_j.Content = "J";
                    lbl_k.Content = "K";
                    lbl_l.Content = "L";
                    lbl_m.Content = "M";
                    lbl_n.Content = "N";
                    lbl_o.Content = "O";
                    lbl_p.Content = "P";
                    lbl_q.Content = "Q";
                    lbl_r.Content = "R";
                    lbl_s.Content = "S";
                    lbl_t.Content = "T";
                    lbl_u.Content = "U";
                    lbl_v.Content = "V";
                    lbl_w.Content = "W";
                    lbl_x.Content = "X";
                    lbl_y.Content = "Y";
                    lbl_z.Content = "Z";

                    lbl_1.Content = "!";
                    lbl_2.Content = "@";
                    lbl_3.Content = "#";
                    lbl_4.Content = "$";
                    lbl_5.Content = "%";
                    lbl_6.Content = "^";
                    lbl_7.Content = "&";
                    lbl_8.Content = "*";
                    lbl_9.Content = "(";
                    lbl_0.Content = ")";

                    lbl_spcl1.Content = "_";
                    lbl_spcl2.Content = "+";
                    lbl_spcl3.Content = "{";
                    lbl_spcl4.Content = "}";
                    lbl_spcl5.Content = "|";
                    lbl_spcl6.Content = ":";
                    lbl_spcl7.Content = '"';
                    lbl_spcl8.Content = "<";
                    lbl_spcl9.Content = ">";
                    lbl_spcl10.Content = "?";
                }
                else
                {
                    lbl_shift.Background = Brushes.White;

                    lbl_a.Content = "a";
                    lbl_b.Content = "b";
                    lbl_c.Content = "c";
                    lbl_d.Content = "d";
                    lbl_e.Content = "e";
                    lbl_f.Content = "f";
                    lbl_g.Content = "g";
                    lbl_h.Content = "h";
                    lbl_i.Content = "i";
                    lbl_j.Content = "j";
                    lbl_k.Content = "k";
                    lbl_l.Content = "l";
                    lbl_m.Content = "m";
                    lbl_n.Content = "n";
                    lbl_o.Content = "o";
                    lbl_p.Content = "p";
                    lbl_q.Content = "q";
                    lbl_r.Content = "r";
                    lbl_s.Content = "s";
                    lbl_t.Content = "t";
                    lbl_u.Content = "u";
                    lbl_v.Content = "v";
                    lbl_w.Content = "w";
                    lbl_x.Content = "x";
                    lbl_y.Content = "y";
                    lbl_z.Content = "z";

                    lbl_1.Content = "1";
                    lbl_2.Content = "2";
                    lbl_3.Content = "3";
                    lbl_4.Content = "4";
                    lbl_5.Content = "5";
                    lbl_6.Content = "6";
                    lbl_7.Content = "7";
                    lbl_8.Content = "8";
                    lbl_9.Content = "9";
                    lbl_0.Content = "9";

                    lbl_spcl1.Content = "-";
                    lbl_spcl2.Content = "=";
                    lbl_spcl3.Content = "[";
                    lbl_spcl4.Content = "]";
                    lbl_spcl5.Content = '\'';
                    lbl_spcl6.Content = ";";
                    lbl_spcl7.Content = "'";
                    lbl_spcl8.Content = ",";
                    lbl_spcl9.Content = ".";
                    lbl_spcl10.Content = "/";
                }
            }

            else if (e.Key == Key.Back) //For Erasing Content
            {
                shiftPressed = false;
                if (lbl_input.Content.ToString().Length > 0)
                {
                    key_button();
                    lbl_back.Background = Brushes.Yellow;
                    lbl_input.Content = lbl_input.Content.ToString().Substring(0, lbl_input.Content.ToString().Length - 1);
                }
                else
                {
                    key_button();
                    MessageBox.Show("There are no content to be erased.");
                }
            }

            else
            {
                switch (e.Key)
                {
                    case Key.Space:
                        shiftPressed = false;
                        key_button();
                        lbl_space.Background = Brushes.Yellow;
                        retVal = " ";
                        break;
                    case Key.Tab:
                        shiftPressed = false;
                        key_button();
                        lbl_tab.Background = Brushes.Yellow;
                        retVal = "\t";
                        break;
                    case Key.A:
                        if (capsLockActive)
                        {
                            key_button();
                            lbl_a.Background = Brushes.Yellow;
                            retVal = "A";
                        }
                        else if (shiftPressed)
                        {
                            key_button();
                            key_reset();
                            shiftPressed = false;
                            lbl_a.Background = Brushes.Yellow;
                            retVal = "A";
                        }
                        else
                        {
                            key_button();
                            lbl_a.Background = Brushes.Yellow;
                            retVal = "a";
                        }
                        break;
                    case Key.B:
                        if (capsLockActive)
                        {
                            key_button();
                            lbl_b.Background = Brushes.Yellow;
                            retVal = "B";
                        }
                        else if (shiftPressed)
                        {
                            key_button();
                            key_reset();
                            shiftPressed = false;
                            lbl_b.Background = Brushes.Yellow;
                            retVal = "B";
                        }
                        else
                        {
                            key_button();
                            lbl_b.Background = Brushes.Yellow;
                            retVal = "b";
                        }
                        break;
                    case Key.C:
                        if (capsLockActive)
                        {
                            key_button();
                            lbl_c.Background = Brushes.Yellow;
                            retVal = "C";
                        }
                        else if (shiftPressed)
                        {
                            key_button();
                            key_reset();
                            shiftPressed = false;
                            lbl_c.Background = Brushes.Yellow;
                            retVal = "C";
                        }
                        else
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_c.Background = Brushes.Yellow;
                            retVal = "c";
                        }
                        break;
                    case Key.D:
                        if (capsLockActive)
                        {
                            key_button();
                            lbl_d.Background = Brushes.Yellow;
                            retVal = "D";
                        }
                        else if (shiftPressed)
                        {
                            key_button();
                            key_reset();
                            shiftPressed = false;
                            lbl_d.Background = Brushes.Yellow;
                            retVal = "D";
                        }
                        else
                        {
                            key_button();
                            lbl_d.Background = Brushes.Yellow;
                            retVal = "d";
                        }
                        break;
                    case Key.E:
                        if (capsLockActive)
                        {
                            key_button();
                            lbl_e.Background = Brushes.Yellow;
                            retVal = "E";
                        }
                        else if (shiftPressed)
                        {
                            key_button();
                            key_reset();
                            shiftPressed = false;
                            lbl_e.Background = Brushes.Yellow;
                            retVal = "E";
                        }
                        else
                        {
                            key_button();
                            lbl_e.Background = Brushes.Yellow;
                            retVal = "e";
                        }
                        break;
                    case Key.F:
                        if (capsLockActive)
                        {
                            key_button();
                            lbl_f.Background = Brushes.Yellow;
                            retVal = "F";
                        }
                        else if (shiftPressed)
                        {
                            key_button();
                            key_reset();
                            shiftPressed = false;
                            lbl_f.Background = Brushes.Yellow;
                            retVal = "F";
                        }
                        else
                        {
                            key_button();
                            lbl_f.Background = Brushes.Yellow;
                            retVal = "f";
                        }
                        break;
                    case Key.G:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_g.Background = Brushes.Yellow;
                            retVal = "G";
                        }
                        else
                        {
                            key_button();
                            lbl_g.Background = Brushes.Yellow;
                            retVal = "g";
                        }
                        break;
                    case Key.H:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_h.Background = Brushes.Yellow;
                            retVal = "H";
                        }
                        else
                        {
                            key_button();
                            lbl_h.Background = Brushes.Yellow;
                            retVal = "h";
                        }
                        break;
                    case Key.I:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_i.Background = Brushes.Yellow;
                            retVal = "I";
                        }
                        else
                        {
                            key_button();
                            lbl_i.Background = Brushes.Yellow;
                            retVal = "i";
                        }
                        break;
                    case Key.J:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_j.Background = Brushes.Yellow;
                            retVal = "J";
                        }
                        else
                        {
                            key_button();
                            lbl_j.Background = Brushes.Yellow;
                            retVal = "j";
                        }
                        break;
                    case Key.K:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_k.Background = Brushes.Yellow;
                            retVal = "K";
                        }
                        else
                        {
                            key_button();
                            lbl_k.Background = Brushes.Yellow;
                            retVal = "k";
                        }
                        break;
                    case Key.L:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_l.Background = Brushes.Yellow;
                            retVal = "L";
                        }
                        else
                        {
                            key_button();
                            lbl_l.Background = Brushes.Yellow;
                            retVal = "l";
                        }
                        break;
                    case Key.M:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_m.Background = Brushes.Yellow;
                            retVal = "M";
                        }
                        else
                        {
                            key_button();
                            lbl_m.Background = Brushes.Yellow;
                            retVal = "m";
                        }
                        break;
                    case Key.N:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_n.Background = Brushes.Yellow;
                            retVal = "N";
                        }
                        else
                        {
                            key_button();
                            lbl_n.Background = Brushes.Yellow;
                            retVal = "n";
                        }
                        break;
                    case Key.O:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_o.Background = Brushes.Yellow;
                            retVal = "O";
                        }
                        else
                        {
                            key_button();
                            lbl_o.Background = Brushes.Yellow;
                            retVal = "o";
                        }
                        break;
                    case Key.P:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_p.Background = Brushes.Yellow;
                            retVal = "P";
                        }
                        else
                        {
                            key_button();
                            lbl_p.Background = Brushes.Yellow;
                            retVal = "p";
                        }
                        break;
                    case Key.Q:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_q.Background = Brushes.Yellow;
                            retVal = "Q";
                        }
                        else
                        {
                            key_button();
                            lbl_q.Background = Brushes.Yellow;
                            retVal = "q";
                        }
                        break;
                    case Key.R:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_r.Background = Brushes.Yellow;
                            retVal = "R";
                        }
                        else
                        {
                            key_button();
                            lbl_r.Background = Brushes.Yellow;
                            retVal = "r";
                        }
                        break;
                    case Key.S:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_s.Background = Brushes.Yellow;
                            retVal = "S";
                        }
                        else
                        {
                            key_button();
                            lbl_s.Background = Brushes.Yellow;
                            retVal = "s";
                        }
                        break;
                    case Key.T:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_t.Background = Brushes.Yellow;
                            retVal = "T";
                        }
                        else
                        {
                            key_button();
                            lbl_t.Background = Brushes.Yellow;
                            retVal = "t";
                        }
                        break;
                    case Key.U:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_u.Background = Brushes.Yellow;
                            retVal = "U";
                        }
                        else
                        {
                            key_button();
                            lbl_u.Background = Brushes.Yellow;
                            retVal = "u";
                        }
                        break;
                    case Key.V:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_v.Background = Brushes.Yellow;
                            retVal = "V";
                        }
                        else
                        {
                            key_button();
                            lbl_v.Background = Brushes.Yellow;
                            retVal = "v";
                        }
                        break;
                    case Key.W:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_w.Background = Brushes.Yellow;
                            retVal = "W";
                        }
                        else
                        {
                            key_button();
                            lbl_w.Background = Brushes.Yellow;
                            retVal = "w";
                        }
                        break;
                    case Key.X:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_x.Background = Brushes.Yellow;
                            retVal = "X";
                        }
                        else
                        {
                            key_button();
                            lbl_x.Background = Brushes.Yellow;
                            retVal = "x";
                        }
                        break;
                    case Key.Y:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_y.Background = Brushes.Yellow;
                            retVal = "Y";
                        }
                        else
                        {
                            key_button();
                            lbl_y.Background = Brushes.Yellow;
                            retVal = "y";
                        }
                        break;
                    case Key.Z:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_z.Background = Brushes.Yellow;
                            retVal = "Z";
                        }
                        else
                        {
                            key_button();
                            lbl_z.Background = Brushes.Yellow;
                            retVal = "z";
                        }
                        break;
                    case Key.D1:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_1.Background = Brushes.Yellow;
                            retVal = "!";
                        }
                        else
                        {
                            key_button();
                            lbl_1.Background = Brushes.Yellow;
                            retVal = "1";
                        }
                        break;
                    case Key.D2:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_2.Background = Brushes.Yellow;
                            retVal = "@";
                        }
                        else
                        {
                            key_button();
                            lbl_2.Background = Brushes.Yellow;
                            retVal = "2";
                        }
                        break;
                    case Key.D3:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_3.Background = Brushes.Yellow;
                            retVal = "#";
                        }
                        else
                        {
                            key_button();
                            lbl_3.Background = Brushes.Yellow;
                            retVal = "3";
                        }
                        break;
                    case Key.D4:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_4.Background = Brushes.Yellow;
                            retVal = "$";
                        }
                        else
                        {
                            key_button();
                            lbl_4.Background = Brushes.Yellow;
                            retVal = "4";
                        }
                        break;
                    case Key.D5:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_5.Background = Brushes.Yellow;
                            retVal = "%";
                        }
                        else
                        {
                            key_button();
                            lbl_5.Background = Brushes.Yellow;
                            retVal = "5";
                        }
                        break;
                    case Key.D6:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_6.Background = Brushes.Yellow;
                            retVal = "^";
                        }
                        else
                        {
                            key_button();
                            lbl_6.Background = Brushes.Yellow;
                            retVal = "6";
                        }
                        break;
                    case Key.D7:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_7.Background = Brushes.Yellow;
                            retVal = "&";
                        }
                        else
                        {
                            key_button();
                            lbl_7.Background = Brushes.Yellow;
                            retVal = "7";
                        }
                        break;
                    case Key.D8:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_8.Background = Brushes.Yellow;
                            retVal = "*";
                        }
                        else
                        {
                            key_button();
                            lbl_8.Background = Brushes.Yellow;
                            retVal = "8";
                        }
                        break;
                    case Key.D9:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_9.Background = Brushes.Yellow;
                            retVal = "(";
                        }
                        else
                        {
                            key_button();
                            lbl_8.Background = Brushes.Yellow;
                            retVal = "9";
                        }
                        break;
                    case Key.D0:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_0.Background = Brushes.Yellow;
                            retVal = ")";
                        }
                        else
                        {
                            key_button();
                            lbl_0.Background = Brushes.Yellow;
                            retVal = "0";
                        }
                        break;
                    case Key.OemMinus:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_spcl1.Background = Brushes.Yellow;
                            retVal = "_";
                        }
                        else
                        {
                            key_button();
                            lbl_spcl1.Background = Brushes.Yellow;
                            retVal = "-";
                        }
                        break;
                    case Key.OemPlus:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_spcl2.Background = Brushes.Yellow;
                            retVal = "+";
                        }
                        else
                        {
                            key_button();
                            lbl_spcl2.Background = Brushes.Yellow;
                            retVal = "=";
                        }
                        break;
                    case Key.OemOpenBrackets:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_spcl3.Background = Brushes.Yellow;
                            retVal = "{";
                        }
                        else
                        {
                            key_button();
                            lbl_spcl3.Background = Brushes.Yellow;
                            retVal = "[";
                        }
                        break;
                    case Key.OemCloseBrackets:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_spcl4.Background = Brushes.Yellow;
                            retVal = "}";
                        }
                        else
                        {
                            key_button();
                            lbl_spcl4.Background = Brushes.Yellow;
                            retVal = "]";
                        }
                        break;
                    case Key.OemPipe:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_spcl5.Background = Brushes.Yellow;
                            retVal = "|";
                        }
                        else
                        {
                            key_button();
                            lbl_spcl5.Background = Brushes.Yellow;
                            retVal = "\\";
                        }
                        break;
                    case Key.OemSemicolon:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_spcl6.Background = Brushes.Yellow;
                            retVal = ":";
                        }
                        else
                        {
                            key_button();
                            lbl_spcl6.Background = Brushes.Yellow;
                            retVal = ";";
                        }
                        break;
                    case Key.OemQuotes:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_spcl7.Background = Brushes.Yellow;
                            retVal = "\"";
                        }
                        else
                        {
                            key_button();
                            lbl_spcl7.Background = Brushes.Yellow;
                            retVal = "'";
                        }
                        break;
                    case Key.OemComma:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_spcl8.Background = Brushes.Yellow;
                            retVal = "<";
                        }
                        else
                        {
                            key_button();
                            lbl_spcl8.Background = Brushes.Yellow;
                            retVal = ",";
                        }
                        break;
                    case Key.OemPeriod:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_spcl9.Background = Brushes.Yellow;
                            retVal = ">";
                        }
                        else
                        {
                            key_button();
                            lbl_spcl9.Background = Brushes.Yellow;
                            retVal = ".";
                        }
                        break;
                    case Key.OemQuestion:
                        if (shiftPressed || capsLockActive)
                        {
                            shiftPressed = false;
                            key_button();
                            lbl_spcl10.Background = Brushes.Yellow;
                            retVal = "?";
                        }
                        else
                        {
                            key_button();
                            lbl_spcl10.Background = Brushes.Yellow;
                            retVal = "/";
                        }
                        break;

                }
                string inputString = retVal;
                lbl_input.Content += inputString;
            }
        }


        private void key_button() // For Resetting the Colors of the Keys 
        {
            lbl_a.Background = Brushes.White;
            lbl_b.Background = Brushes.White;
            lbl_c.Background = Brushes.White;
            lbl_d.Background = Brushes.White;
            lbl_e.Background = Brushes.White;
            lbl_f.Background = Brushes.White;
            lbl_g.Background = Brushes.White;
            lbl_h.Background = Brushes.White;
            lbl_i.Background = Brushes.White;
            lbl_j.Background = Brushes.White;
            lbl_k.Background = Brushes.White;
            lbl_l.Background = Brushes.White;
            lbl_m.Background = Brushes.White;
            lbl_n.Background = Brushes.White;
            lbl_o.Background = Brushes.White;
            lbl_p.Background = Brushes.White;
            lbl_q.Background = Brushes.White;
            lbl_r.Background = Brushes.White;
            lbl_s.Background = Brushes.White;
            lbl_t.Background = Brushes.White;
            lbl_u.Background = Brushes.White;
            lbl_v.Background = Brushes.White;
            lbl_w.Background = Brushes.White;
            lbl_x.Background = Brushes.White;
            lbl_y.Background = Brushes.White;
            lbl_z.Background = Brushes.White;

            lbl_1.Background = Brushes.White;
            lbl_2.Background = Brushes.White;
            lbl_3.Background = Brushes.White;
            lbl_4.Background = Brushes.White;
            lbl_5.Background = Brushes.White;
            lbl_6.Background = Brushes.White;
            lbl_7.Background = Brushes.White;
            lbl_8.Background = Brushes.White;
            lbl_9.Background = Brushes.White;
            lbl_0.Background = Brushes.White;

            lbl_spcl1.Background = Brushes.White;
            lbl_spcl2.Background = Brushes.White;
            lbl_spcl3.Background = Brushes.White;
            lbl_spcl4.Background = Brushes.White;
            lbl_spcl5.Background = Brushes.White;
            lbl_spcl6.Background = Brushes.White;
            lbl_spcl7.Background = Brushes.White;
            lbl_spcl8.Background = Brushes.White;
            lbl_spcl9.Background = Brushes.White;
            lbl_spcl10.Background = Brushes.White;

            lbl_tab.Background = Brushes.White;
            lbl_shift.Background = Brushes.White;
            lbl_back.Background = Brushes.White;
            lbl_space.Background = Brushes.White;
        }

        private void key_reset() // For resetting the initial state of the letters after using shift
        {
            lbl_shiftlock.Background = Brushes.White;

            lbl_a.Content = "a";
            lbl_b.Content = "b";
            lbl_c.Content = "c";
            lbl_d.Content = "d";
            lbl_e.Content = "e";
            lbl_f.Content = "f";
            lbl_g.Content = "g";
            lbl_h.Content = "h";
            lbl_i.Content = "i";
            lbl_j.Content = "j";
            lbl_k.Content = "k";
            lbl_l.Content = "l";
            lbl_m.Content = "m";
            lbl_n.Content = "n";
            lbl_o.Content = "o";
            lbl_p.Content = "p";
            lbl_q.Content = "q";
            lbl_r.Content = "r";
            lbl_s.Content = "s";
            lbl_t.Content = "t";
            lbl_u.Content = "u";
            lbl_v.Content = "v";
            lbl_w.Content = "w";
            lbl_x.Content = "x";
            lbl_y.Content = "y";
            lbl_z.Content = "z";

            lbl_1.Content = "1";
            lbl_2.Content = "2";
            lbl_3.Content = "3";
            lbl_4.Content = "4";
            lbl_5.Content = "5";
            lbl_6.Content = "6";
            lbl_7.Content = "7";
            lbl_8.Content = "8";
            lbl_9.Content = "9";
            lbl_0.Content = "9";

            lbl_spcl1.Content = "-";
            lbl_spcl2.Content = "=";
            lbl_spcl3.Content = "[";
            lbl_spcl4.Content = "]";
            lbl_spcl5.Content = '\'';
            lbl_spcl6.Content = ";";
            lbl_spcl7.Content = "'";
            lbl_spcl8.Content = ",";
            lbl_spcl9.Content = ".";
            lbl_spcl10.Content = "/";
        }
    }
}
