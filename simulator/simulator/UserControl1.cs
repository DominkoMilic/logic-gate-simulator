using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulator
{
    public partial class UserControl1 : UserControl
    {
        int inand = 0;
        int inor = 0;
        int cp_counter = 0;
        int current_nmbr = 1;
        int current_nmbr_nor = 0;
        int current_nmbr_nand = 0;
        int cable_index = -1;
        private CircularLabel[] lights;
        private Button[] buttons_X;
        private Button[] buttons_ON;
        private Button[] buttons_Cable_Color;
        private Label[] X_Indicator;
        private DraggableLabel[] nand;
        private DraggableLabel[] nor;
        private Line[] cable = new Line[200];
        private bool isDrawing = false;
        Color[] colors_For_Cables = { Color.Black, Color.Red, Color.Blue, Color.Yellow, Color.Purple };

        public UserControl1()
        {
            InitializeComponent();
            this.MouseDown += MainForm_MouseDown;
            this.MouseMove += MainForm_MouseMove;
            this.MouseUp += MainForm_MouseUp;
            this.Paint += MainForm_Paint;
        }

        private void UserControl1_Load_1(object sender, EventArgs e)
        {
            increment_nand.Enabled = false;
            nILIToolStripMenuItem.Enabled = false;
            LightLabelInitialization(5);
            XButtonInitialization(10);
            ONButtonInitialization();
            CableColorButtonInitialization();
            XIndicatorLabelInitialization(5);
            NANDInitialization(100);
            NORInitialization(100);
            cableInitialization();
            for (int i = 0; i < 5; i++)
            {
                buttons_ON[i].Click += Buttons_ON_click;
            }
        }

        //inicijalizacija objekta cable
        private void cableInitialization()
        {
            for (int i = 0; i < 200; i++)
                cable[i] = new Line();
        }

        //stvaranje okruglih labela koje su zelene za vrijednost 1 i crvene za vrijednost 0
        private void LightLabelInitialization(int number_of_lights)
        {
            lights = new CircularLabel[number_of_lights];

            for (int i = 0; i < number_of_lights; i++)
            {
                lights[i] = new CircularLabel();
                lights[i].Location = new Point(598 - i * 30, 405);
                lights[i].BringToFront();
                lights[i].BackColor = Color.Red;
                this.Controls.Add(lights[i]);
                this.Controls.SetChildIndex(lights[i], 0);//postavlja svijetla ispred drugih labela(send to front)
            }
        }

        //stvaranje botuna X !X za varijable X
        private void XButtonInitialization(int number_of_buttons_x)
        {
            buttons_X = new Button[number_of_buttons_x];
            int br_X = 0;
            for (int i = 0; i < number_of_buttons_x; i++)
            {
                buttons_X[i] = new Button();
                if (i % 2 == 0)
                {
                    buttons_X[i].Text = "X" + br_X;
                    br_X++;
                }
                else
                {
                    buttons_X[i].Text = "!X" + (br_X - 1);
                }
                buttons_X[i].Location = new System.Drawing.Point(50, 18 + i / 2 * 20 + i * 25);
                buttons_X[i].Visible = false;
                buttons_X[i].Font = new System.Drawing.Font(buttons_X[i].Font.FontFamily, 8, System.Drawing.FontStyle.Bold);
                buttons_X[i].Size = new Size(30, 30);
                buttons_X[i].TextAlign = ContentAlignment.MiddleCenter;
                buttons_X[i].BackColor = Color.LightBlue;
                this.Controls.Add(buttons_X[i]);
            }
            buttons_X[0].Visible = true;
            buttons_X[1].Visible = true;
        }

        //stvaranje botuna za davanje vrijednosti varijablama X
        private void ONButtonInitialization()
        {
            buttons_ON = new Button[5];
            for (int i = 0; i < 5; i++)
            {
                buttons_ON[i] = new Button();
                buttons_ON[i].Location = new System.Drawing.Point(590 - i * 30, 420);
                buttons_ON[i].Visible = true;
                buttons_ON[i].Font = new System.Drawing.Font(buttons_ON[i].Font.FontFamily, 8, System.Drawing.FontStyle.Bold);
                buttons_ON[i].Size = new Size(25, 20);
                buttons_ON[i].TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(buttons_ON[i]);
                this.Controls.SetChildIndex(buttons_ON[i], 0);
            }
        }

        //stvaranje botuna za boju kabela
        private void CableColorButtonInitialization()
        {
            buttons_Cable_Color = new Button[5];
            for (int i = 0; i < 5; i++)
            {
                buttons_Cable_Color[i] = new Button();
                buttons_Cable_Color[i].Location = new System.Drawing.Point(340 + 18 * i, 410);
                buttons_Cable_Color[i].Visible = true;
                buttons_Cable_Color[i].Size = new Size(18, 30);
                buttons_Cable_Color[i].BackColor = colors_For_Cables[i];
                buttons_Cable_Color[i].Click += CableColorButton_Click;
                this.Controls.Add(buttons_Cable_Color[i]);
                this.Controls.SetChildIndex(buttons_Cable_Color[i], 0);
            }
        }

        //postavljanje labela X0 - X4
        private void XIndicatorLabelInitialization(int number_of_label)
        {
            X_Indicator = new Label[number_of_label];
            for (int i = 0; i < number_of_label; i++)
            {
                X_Indicator[i] = new Label();
                X_Indicator[i].Text = "X" + i;
                X_Indicator[i].Location = new System.Drawing.Point(0, (i + 1) * 20 + i * 50);
                X_Indicator[i].Visible = false;
                X_Indicator[i].Font = new System.Drawing.Font(X_Indicator[i].Font.FontFamily, 10, System.Drawing.FontStyle.Bold);
                X_Indicator[i].Size = new Size(50, 50);
                X_Indicator[i].TextAlign = ContentAlignment.MiddleCenter;
                X_Indicator[i].BackColor = Color.LightBlue;
                X_Indicator[i].BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(X_Indicator[i]);
            }
            X_Indicator[0].Visible = true;
        }

        //stvaranje nand labela
        private void NANDInitialization(int number_of_nand)
        {
            nand = new DraggableLabel[number_of_nand];

            for (int i = 0; i < number_of_nand; i++)
            {
                nand[i] = new DraggableLabel();
                nand[i].Visible = false;
                nand[i].Location = new Point(350, 150);
                nand[i].Tag = "nand" + i;
                nand[i].Text = "";
                nand[i].TextAlign = ContentAlignment.MiddleCenter;
                nand[i].ForeColor = Color.FromArgb(224, 224, 224);

                try
                {
                    Image img = Resource1.NAND6;
                    nand[i].Image = img;
                    nand[i].AutoSize = false;
                    nand[i].Size = img.Size;
                    this.Controls.Add(nand[i]);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //stvaranje nor labela
        private void NORInitialization(int number_of_nor)
        {
            nor = new DraggableLabel[number_of_nor];

            for (int i = 0; i < number_of_nor; i++)
            {
                nor[i] = new DraggableLabel();
                nor[i].Visible = false;
                nor[i].Location = new Point(350, 150);
                nor[i].Tag = "nor" + i;
                nor[i].Text = "";
                nor[i].TextAlign = ContentAlignment.MiddleCenter;
                nor[i].ForeColor = Color.FromArgb(224, 224, 224);

                try
                {
                    Image img = Resource1.NOR5;
                    nor[i].Image = img;
                    nor[i].AutoSize = false;
                    nor[i].Size = img.Size;
                    this.Controls.Add(nor[i]);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //paljenje(1) i gasenje(0) vrijednosti za pojedini X
        private void Buttons_ON_click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int i = Array.IndexOf(buttons_ON, clickedButton);

            if (lights[i].BackColor == Color.Green)
                lights[i].BackColor = Color.Red;
            else if (lights[i].BackColor == Color.Red)
                lights[i].BackColor = Color.Green;

            string binary = "00000";
            for (int j = 0; j < 5; j++)
            {
                if (lights[j].BackColor == Color.Green)
                    binary = binary.Substring(0, 5 - 1 - j) + '1' + binary.Substring(5 - j);
            }

            cp_counter = Convert.ToInt32(binary, 2);

            if (increment_nor.Enabled == true)
            {
                for (int k = 0; k < nor.Length; k++)
                {
                    nor[k].Text = "";
                }
                Next(buttons_X);
                Next(nor);
            }
            else if (increment_nand.Enabled == true)
            {
                for (int k = 0; k < nand.Length; k++)
                {
                    nand[k].Text = "";
                }
                Next(buttons_X);
                Next(nand);
            }
            EndPointIntersectingExit();

        }

        //dodavanje varijabli X !X
        private void increment_variable_X_Click(object sender, EventArgs e)
        {
            if (current_nmbr < 5)
                current_nmbr++;
            number_of_X.Text = current_nmbr.ToString();
            for (int i = 0; i < current_nmbr; i++)
            {
                X_Indicator[i].Visible = true;
                buttons_X[i * 2].Visible = true;
                buttons_X[i * 2 + 1].Visible = true;
            }
        }

        //uklanjanje varijabli X !X
        private void decrement_variable_X_Click(object sender, EventArgs e)
        {
            if (current_nmbr > 1)
                current_nmbr--;
            number_of_X.Text = current_nmbr.ToString();
            for (int i = current_nmbr; i < 5; i++)
            {
                X_Indicator[i].Visible = false;
                buttons_X[i * 2].Visible = false;
                buttons_X[i * 2 + 1].Visible = false;
            }
        }

        //dodavanje nili vrata
        private void increment_nor_Click(object sender, EventArgs e)
        {
            if (current_nmbr_nor < 100)
            {
                current_nmbr_nor++;
                nor[inor].Visible = true;
            }
            inor++;
        }

        //dodavanje ni vrata
        private void increment_nand_Click(object sender, EventArgs e)
        {
            if (current_nmbr_nand < 100)
            {
                current_nmbr_nand++;
                nand[inand].Visible = true;
            }
            inand++;
        }

        //postavljanje labela svijetlo na 0 (crveno)
        private void reset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                lights[i].BackColor = Color.Red;
            cp_counter = 0;
            EndPointIntersectingExit();
        }

        //vrtnja svih mogucih kombinacija svijetala (binarno od 0 do 32)
        private void counting_point_Click(object sender, EventArgs e)
        {
            cp_counter++;
            string binaryi = Convert.ToString(cp_counter, 2);
            binaryi = binaryi.PadLeft(5, '0');
            for (int i = 0; i < 5; i++)
            {
                if (binaryi[binaryi.Length - i - 1] == '1')
                {
                    lights[i].BackColor = Color.Green;
                }
                else
                {
                    lights[i].BackColor = Color.Red;
                }
            }
            if (cp_counter == 32)
                cp_counter = 0;
            if (increment_nor.Enabled == true)
            {
                for (int i = 0; i < nor.Length; i++)
                {
                    nor[i].Text = "";
                }
                Next(buttons_X);
                Next(nor);
            }
            else if(increment_nand.Enabled == true)
            {
                for (int i = 0; i < nand.Length; i++)
                {
                    nand[i].Text = "";
                }
                Next(buttons_X);
                Next(nand);
            }
            EndPointIntersectingExit();
        }



        //po mogucnosti nadogradit

        //omogucava crtanje linija
        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < cable.Length; i++)
            {
                Color lineColor = cable[i].lineColors != Color.Empty ? cable[i].lineColors : Color.Black;
                if (cable[i].drawnLine.Count > 1)
                {
                    using (Pen currentLinePen = new Pen(cable[i].lineColors, 3))
                    {
                        e.Graphics.DrawLines(currentLinePen, cable[i].drawnLine.ToArray());
                    }
                }
            }
        }

        //spremanje linije u listu nakon pustanja lijevog klika
        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing && e.Button == MouseButtons.Left)
            {
                isDrawing = false;

                cable[cable_index].lineColors = cable[cable_index].linePen.Color;

                if (!CompleteIntersection())
                {
                    DeleteLine(cable_index);
                }

                for (int i = 0; i < 5; i++)
                {
                    buttons_Cable_Color[i].Enabled = true;
                }
                this.Invalidate();
            }
        }

        //crtanje linije dok je lijevi klik misa pritisnut
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            // Continue drawing while the left mouse button is held down.
            if (isDrawing && e.Button == MouseButtons.Left)
            {
                cable[cable_index].endPoint = e.Location;
                cable[cable_index].drawnLine.Add(e.Location);
                this.Invalidate();
            }
        }

        //omogucava crtanje kabela
        private void add_cabel_Click(object sender, EventArgs e)
        {
            cable_index++;
            isDrawing = true;
            for (int i = 0; i < 5; i++)
            {
                buttons_Cable_Color[i].Enabled = false;
            }
            cable[cable_index].isVisible = true;
            cable[cable_index].lineColors = GetNextLineColor(); // Set color based on the last drawn cable
            cable[cable_index].drawnLine.Clear();
        }

        //zadrzavanje boje vec nacrtanih kabela
        private Color GetNextLineColor()
        {
            if (cable_index > 0)
            {
                return cable[cable_index - 1].linePen.Color;
            }
            else
            {
                return cable[cable_index].linePen.Color;
            }
        }

        //minjanje boje kabela
        private void CableColorButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Color selectedColor = clickedButton.BackColor;
            cable[cable_index + 1].linePen.Color = selectedColor;
        }




        //omogucava brisanje linije na desni klik
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Check if right-click occurred on a line
                CheckDeleteLine(e.Location);
            }
            else if (isDrawing && e.Button == MouseButtons.Left)
            {
                cable[cable_index].drawnLine.Add(e.Location);
                cable[cable_index].startPoint = e.Location;
            }
        }

        //otvara opciju izbrzi ako je desni klik misa pritisnut na liniji
        private void CheckDeleteLine(Point clickPoint)
        {
            for (int i = 0; i < cable.Length; i++)
            {
                if (cable.Length > 1 && LineContainsPoint(cable[i].drawnLine, clickPoint))
                {
                    ShowDeleteLineContextMenu(clickPoint, i);
                    return;
                }
            }
        }

        //gleda sadrzi li linija lokaciju desnog klika misa 
        private bool LineContainsPoint(List<Point> line, Point point)
        {
            for (int i = 1; i < line.Count; i++)
            {
                Point p1 = line[i - 1];
                Point p2 = line[i];
                if (DistanceFromPointToLine(point, p1, p2) < 5) // You can adjust the threshold for proximity
                {
                    return true;
                }
            }
            return false;
        }

        //racunanje udaljenosti izmedu linije i desnog klika misa
        private double DistanceFromPointToLine(Point point, Point lineStart, Point lineEnd)
        {
            double A = point.X - lineStart.X;
            double B = point.Y - lineStart.Y;
            double C = lineEnd.X - lineStart.X;
            double D = lineEnd.Y - lineStart.Y;

            double dot = A * C + B * D;
            double len_sq = C * C + D * D;
            double param = dot / len_sq;

            double xx, yy;

            if (param < 0)
            {
                xx = lineStart.X;
                yy = lineStart.Y;
            }
            else if (param > 1)
            {
                xx = lineEnd.X;
                yy = lineEnd.Y;
            }
            else
            {
                xx = lineStart.X + param * C;
                yy = lineStart.Y + param * D;
            }

            double dx = point.X - xx;
            double dy = point.Y - yy;

            return Math.Sqrt(dx * dx + dy * dy);
        }

        //stvaranje delete opcije za liniju
        private void ShowDeleteLineContextMenu(Point location, int lineIndex)
        {
            ContextMenu deleteMenu = new ContextMenu();
            MenuItem deleteItem = new MenuItem("Delete Line");
            deleteItem.Click += (sender, e) => DeleteLine(lineIndex);
            deleteMenu.MenuItems.Add(deleteItem);

            deleteMenu.Show(this, location);
        }

        //brisanje linije iz forme
        private void DeleteLine(int lineIndex)
        {
            cable[lineIndex].isVisible = false;
            cable[lineIndex].drawnLine.Clear();
            Y_light.BackColor = Color.Red;
            for(int i = 0; i < nor.Count(); i++)
            {
                if (EndIntersecting(nor[i], lineIndex))
                    nor[i].Text = "";
            }
            Invalidate();
        }




        //resetiranje objekta cable
        public void Remove_Cables()
        {
            for (int i = 0; i < 200; i++)
            {
                cable[i].drawnLine.Clear();
                cable[i].linePen = new Pen(Color.Black, 3);
                cable[i].lineColors = Color.Black;
                cable[i].endPoint = Point.Empty;
                cable[i].startPoint = Point.Empty;
                cable[i].value = -1;
                DeleteLine(i);
                cable_index = -1;
                cable[i].isVisible = false;
            }
        }

        //resetiranje broja varijabli na 1
        private void Reset_Number_Of_Variables()
        {
            int.TryParse(number_of_X.Text, out int X);
            while (X > 1)
            {
                decrement_variable_X.PerformClick();
                X--;
            }
        }

        //resetiranje forme
        private void nOVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < current_nmbr_nor; i++)
            {
                nor[inor - current_nmbr_nor].Visible = false;
                nor[inor - current_nmbr_nor].Location = new Point(350, 100);
                //nor[inor - current_nmbr_nor].Parent.Controls.Remove(nor[inor - current_nmbr_nor]);
                inor++;
            }
            current_nmbr_nor = 0;
            for (int i = 0; i < current_nmbr_nand; i++)
            {
                nand[inand - current_nmbr_nand].Visible = false;
                nand[inand - current_nmbr_nand].Location = new Point(350, 100);
                //nand[inand - current_nmbr_nand].Parent.Controls.Remove(nand[inand - current_nmbr_nand]);
                inand++;
            }
            current_nmbr_nand = 0;
            Reset_Number_Of_Variables();
            Remove_Cables();
            reset.PerformClick();
            Y_light.BackColor = Color.Red;
            this.Invalidate();
        }

        //postavljanje na nili vrstu
        private void nILIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < current_nmbr_nand; i++)
            {
                nand[inand - current_nmbr_nand].Visible = false;
                nand[inand - current_nmbr_nand].Location = new Point(350, 100);
                //nand[inand - current_nmbr_nand].Parent.Controls.Remove(nand[inand - current_nmbr_nand]);
                inand++;
            }
            current_nmbr_nand = 0;
            Remove_Cables();
            Reset_Number_Of_Variables();
            reset.PerformClick();
            Y_light.BackColor = Color.Red;
            increment_nor.Enabled = true;
            increment_nand.Enabled = false;
            nILIToolStripMenuItem.Enabled = false;
            nIToolStripMenuItem.Enabled = true;
            this.Invalidate();
        }

        //postavljanje na ni vrstu
        private void nIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < current_nmbr_nor; i++)
            {
                nor[inor - current_nmbr_nor].Visible = false;
                nor[inor - current_nmbr_nor].Location = new Point(350, 100);
                //nor[inor - current_nmbr_nor].Parent.Controls.Remove(nor[inor - current_nmbr_nor]);
                inor++;
            }
            current_nmbr_nor = 0;
            Remove_Cables();
            Reset_Number_Of_Variables();
            reset.PerformClick();
            Y_light.BackColor = Color.Red;
            increment_nand.Enabled = true;
            increment_nor.Enabled = false;
            nIToolStripMenuItem.Enabled = false;
            nILIToolStripMenuItem.Enabled = true;
            this.Invalidate();
        }


        //svi kabeli i labele dobivaju sljedece vrijednosti
        private void Next(Control[] control1)
        {
            for(int i = 0; i <= cable_index; i++)
            {
                foreach (Control control in control1)
                {
                    Rectangle area = control.Bounds;
                    area.Inflate(10, 0);
                    if (area.Contains(cable[i].startPoint) == true && control.Visible == true)
                    {
                        if (control is Button button)
                        {
                            int index = Array.IndexOf(control1, button);
                            cable[i].value = Value_Of_X(index);
                        }
                        if (control is DraggableLabel label)
                        {
                            int index = Array.IndexOf(control1, label);
                            cable[i].value = label.exitValue;
                            if (increment_nor.Enabled == true)
                                CalculateNOR();
                            else if (increment_nand.Enabled == true)
                                CalculateNAND();
                        }
                    }
                }
            }
        }



        //provjera presjeca li pocetak kabela neku kontrolu
        private bool StartPointIntersecting(Control[] control1)
        {
            foreach (Control control in control1)
            {
                Rectangle area = control.Bounds;
                area.Inflate(10, 0);
                if (cable_index >= 0 && area.Contains(cable[cable_index].startPoint) == true && control.Visible == true)
                {
                    if(control is Button button)
                    {
                        int index = Array.IndexOf(control1, button);
                        cable[cable_index].value = Value_Of_X(index);
                    }
                    if(control is DraggableLabel label)
                    {
                        int index = Array.IndexOf(control1, label);
                        cable[cable_index].value = label.exitValue;
                    }
                    return true;
                }
            }
            return false;
        }

        //provjera presjeca li kraj kabela neku kontrolu
        private bool EndPointIntersecting(Control[] control1)
        {
            foreach (Control control in control1)
            {
                Rectangle area = control.Bounds;
                area.Inflate(10, 0);
                if (cable_index >= 0 && area.Contains(cable[cable_index].endPoint) == true && control.Visible == true)
                    return true;
            }
            return false;
        }

        //provjera presjeca li kraj kabela kontrolu tocnog indeksa
        private bool EndIntersecting(DraggableLabel control1, int index)
        {
            Rectangle area = control1.Bounds;
            area.Inflate(10, 0);
            if (cable_index >= 0 && area.Contains(cable[index].endPoint) == true && control1.Visible == true)
                return true;
            return false;
        }

        //provjera presjeca li kraj kabela izlaz
        private bool EndPointIntersectingExit()
        {
            Rectangle area = exit.Bounds;
            area.Inflate(10, 0);
            for(int i = 0; i < cable_index; i++)
            {
                if (area.Contains(cable[i].endPoint))
                    DeleteLine(i);
            }
            for (int j = 0; j <= cable_index; j++)
            {
                if (cable_index >= 0 && area.Contains(cable[j].endPoint) == true)
                {
                    if (cable[j].value == 1)
                        Y_light.BackColor = Color.Green;
                    else
                        Y_light.BackColor = Color.Red;
                    return true;
                }

            }
            return false;
        }

        //provjera pocinje li i zavrsava kabel u granicama neke kontrole
        private bool CompleteIntersection()
        {
            if (StartPointIntersecting(buttons_X) && (EndPointIntersecting(nor) || EndPointIntersecting(nand) || EndPointIntersectingExit()))
                return true;
            else if ((StartPointIntersecting(nor) || StartPointIntersecting(nand)) && (EndPointIntersecting(nor) || EndPointIntersecting(nand) || EndPointIntersectingExit()))
                return true;
            else
                return false;
        }
        
        //vrijednost odredenog X-a
        private int Value_Of_X(int i)
        {
            if (lights[i / 2].BackColor == Color.Green && i % 2 == 0)
                return 1;
            else if (lights[i / 2].BackColor == Color.Red && i % 2 == 0)
                return 0;
            else if (lights[i / 2].BackColor == Color.Green && i % 2 != 0)
                return 0;
            else if (lights[i / 2].BackColor == Color.Red && i % 2 != 0)
                return 1;
            return 0;
        }


        //racunajne teksta od nand u izlaz
        private int ExitValueNAND(int index)

        {
            int suma = 0;
            for (int k = 0; k < nand[index].Text.Length; k++)
            {
                int result = int.Parse(nand[index].Text[k].ToString());
                suma += result;
            }
            if (suma == 0)
            {
                nand[index].exitValue = 0;
                return 0;
            }
            else
            {
                nand[index].exitValue = 1;
                return 1;
            }
        }

        //racunanje nand
        private void CalculateNAND()
        {
            List<DraggableLabel> sortedNAND = nand.OrderBy(l => l.Left).ToList();

            int cnt = 0;
            for (int i = 0; i < sortedNAND.Count; i++)
            {
                DraggableLabel currentLabel = sortedNAND[i];
                currentLabel.Text = "";

                for (int j = 0; j < 200; j++)
                {
                    if (EndIntersecting(currentLabel, j))
                    {
                        if (cable[j].isVisible)
                            currentLabel.Text += cable[j].value.ToString();
                    }
                }
                int index = Array.IndexOf(nand, currentLabel);
                ExitValueNAND(index);
                Rectangle area = nand[index].Bounds;
                area.Inflate(10, 0);
                for (int j = 0; j <= cable_index; j++)
                {
                    if (area.Contains(cable[j].startPoint))
                    {
                        cable[j].value = nand[index].exitValue;
                    }
                }
                nand[cnt].Text = currentLabel.Text;

                cnt++;
            }
        }


        //racunajne teksta od nor u izlaz
        private int ExitValueNOR(int index)

        {
            int suma = 0;
            for (int k = 0; k < nor[index].Text.Length; k++)
            {
                int result = int.Parse(nor[index].Text[k].ToString());
                suma += result;
            }
            if (suma == 0)
            {
                nor[index].exitValue = 1;
                return 1;
            }
            else
            {
                nor[index].exitValue = 0;
                return 0;
            }
        }

        //racunanje nor
        private void CalculateNOR()
        {
            List<DraggableLabel> sortedNOR = nor.OrderBy(l => l.Left).ToList();
            
            int cnt = 0;
            for (int i = 0; i < sortedNOR.Count; i++)
            {
                DraggableLabel currentLabel = sortedNOR[i];
                currentLabel.Text = "";

                for (int j = 0; j < 200; j++)
                {
                    if (EndIntersecting(currentLabel, j))
                    {
                        if(cable[j].isVisible)
                            currentLabel.Text += cable[j].value.ToString();
                    }
                }
                int index = Array.IndexOf(nor, currentLabel);
                ExitValueNOR(index);
                Rectangle area = nor[index].Bounds;
                area.Inflate(10, 0);
                for (int j = 0; j <= cable_index; j++)
                {
                    if(area.Contains(cable[j].startPoint))
                    {
                        cable[j].value = nor[index].exitValue;
                    }
                }
                nor[cnt].Text = currentLabel.Text;

                cnt++;
            }
        }

        //pokretanje ploce
        private void start_Click(object sender, EventArgs e)
        {
            reset.PerformClick();
            if (increment_nor.Enabled == true)
            {
                for (int i = 0; i < nor.Length; i++)
                {
                    nor[i].Text = "";
                }
                Next(buttons_X);
                Next(nor);
            }
            else if (increment_nand.Enabled == true)
            {
                for (int i = 0; i < nand.Length; i++)
                {
                    nand[i].Text = "";
                }
                Next(buttons_X);
                Next(nand);
            }
            EndPointIntersectingExit();
        }

        //screenshot forme
        private void Screenshot_Click(object sender, EventArgs e)
        {
            // Get the bounds of the form relative to the screen
            Rectangle bounds = this.RectangleToScreen(this.ClientRectangle);

            Bitmap screenshot = new Bitmap(bounds.Width, bounds.Height);

            using (Graphics graphics = Graphics.FromImage(screenshot))
            {
                // Copy the content of the form from the screen
                graphics.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size);
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Save Screenshot";
                saveFileDialog.Filter = "PNG Image|*.png";
                saveFileDialog.FileName = "screenshot.png"; // Default filename

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Save the screenshot with the specified filename and location
                    screenshot.Save(saveFileDialog.FileName);
                    MessageBox.Show($"Screenshot taken and saved as {saveFileDialog.FileName}");
                }
            }
        }
    }

    public class Line
    {
        public int value;
        public List<Point> drawnLine = new List<Point>();
        public Point startPoint;
        public Point endPoint;
        public Pen linePen = new Pen(Color.Black, 3);
        public Color lineColors = new Color();
        public bool isVisible = true;
    }

    public class DraggableLabel : Label
    {
        private Point offset;
        private ContextMenuStrip contextMenu;
        public int exitValue;

        public DraggableLabel()
        {
            InitializeContextMenu();
        }

        private void InitializeContextMenu()
        {
            contextMenu = new ContextMenuStrip();
            ToolStripMenuItem deleteItem = new ToolStripMenuItem("Remove");
            deleteItem.Click += DeleteItem_Click;
            contextMenu.Items.Add(deleteItem);

            this.ContextMenuStrip = contextMenu;
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
            ContextMenuStrip parentMenu = clickedItem.Owner as ContextMenuStrip;
            DraggableLabel labelToRemove = parentMenu.SourceControl as DraggableLabel;
            if (labelToRemove != null)
            {
                labelToRemove.Parent.Controls.Remove(labelToRemove);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            offset = e.Location;
            BringToFront();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                int newX = Left + e.X - offset.X;
                int newY = Top + e.Y - offset.Y;
                newX = Math.Max(Math.Min(newX, 630 - Width), 100);
                newY = Math.Max(Math.Min(newY, 370 - Height), 24);

                Location = new Point(newX, newY);
            }
        }

    }

    public class CircularLabel : Label
    {
        public CircularLabel()
        {
            this.AutoSize = false;
            this.Size = new Size(10, 10);
            this.BackColor = Color.Red;
            SetCircularRegion();
        }

        private void SetCircularRegion()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, this.Width, this.Height);
            this.Region = new Region(path);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
    }
}
