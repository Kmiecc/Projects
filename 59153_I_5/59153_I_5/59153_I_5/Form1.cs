using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _59153_I_5
{
    public partial class MK_59153_form1 : Form
    {
        //zdefiniowanie dwóch zmiennych (liczba pixeli do poruszania się oraz o ile zwiększy się nasz label)
        int MK_59153_amountOfPixelsToMove = 5;
        int MK_59153_resizeAmount = 4;
        
        public MK_59153_form1()
        {
            MK_59153_Initialization();
        }
        #region Initialize Component
        //utworzenie wszystkich wykorzystywanych obiektów
        Button MK_59153_UpLeft;
        Button MK_59153_Up;
        Button MK_59153_UpRight;
        Button MK_59153_Left;
        Button MK_59153_SizeUp;
        Button MK_59153_Right;
        Button MK_59153_DownLeft;
        Button MK_59153_Down;
        Button MK_59153_DownRight;
        Label MK_59153_Box;
        Button MK_59153_SizeDown;
        Panel MK_59153_panel;
        Label MK_59153_instructionW;
        Label MK_59153_instructionE;
        Label MK_59153_instructionD;
        Label MK_59153_instructionC;
        Label MK_59153_instructionS;
        Label MK_59153_instructionZ;
        Label MK_59153_instructionA;
        Label MK_59153_instructionQ;
        Label MK_59153_instructionSizeUp;
        Label MK_59153_instructionSizeDown;
        Label MK_59153_legend;

        private void MK_59153_Initialization()
        {
            //powołanie do życia obiektów
            this.MK_59153_UpLeft = new System.Windows.Forms.Button();
            this.MK_59153_Up = new System.Windows.Forms.Button();
            this.MK_59153_UpRight = new System.Windows.Forms.Button();
            this.MK_59153_Left = new System.Windows.Forms.Button();
            this.MK_59153_SizeUp = new System.Windows.Forms.Button();
            this.MK_59153_Right = new System.Windows.Forms.Button();
            this.MK_59153_DownLeft = new System.Windows.Forms.Button();
            this.MK_59153_Down = new System.Windows.Forms.Button();
            this.MK_59153_DownRight = new System.Windows.Forms.Button();
            this.MK_59153_Box = new System.Windows.Forms.Label();
            this.MK_59153_SizeDown = new System.Windows.Forms.Button();
            this.MK_59153_panel = new System.Windows.Forms.Panel();
            this.MK_59153_instructionW = new System.Windows.Forms.Label();
            this.MK_59153_instructionE = new System.Windows.Forms.Label();
            this.MK_59153_instructionD = new System.Windows.Forms.Label();
            this.MK_59153_instructionC = new System.Windows.Forms.Label();
            this.MK_59153_instructionS = new System.Windows.Forms.Label();
            this.MK_59153_instructionZ = new System.Windows.Forms.Label();
            this.MK_59153_instructionA = new System.Windows.Forms.Label();
            this.MK_59153_instructionQ = new System.Windows.Forms.Label();
            this.MK_59153_instructionSizeUp = new System.Windows.Forms.Label();
            this.MK_59153_instructionSizeDown = new System.Windows.Forms.Label();
            this.MK_59153_legend = new System.Windows.Forms.Label();
            this.MK_59153_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MK_59153_UpLeft
            // 
            this.MK_59153_UpLeft.Location = new System.Drawing.Point(23, 12);
            this.MK_59153_UpLeft.Name = "MK_59153_UpLeft";
            this.MK_59153_UpLeft.Size = new System.Drawing.Size(75, 52);
            this.MK_59153_UpLeft.TabIndex = 0;
            this.MK_59153_UpLeft.Text = "UpLeft";
            this.MK_59153_UpLeft.UseVisualStyleBackColor = true;
            this.MK_59153_UpLeft.Click += new System.EventHandler(this.MK_59153_UpLeft_Click);
            // 
            // MK_59153_Up
            // 
            this.MK_59153_Up.Location = new System.Drawing.Point(104, 12);
            this.MK_59153_Up.Name = "MK_59153_Up";
            this.MK_59153_Up.Size = new System.Drawing.Size(75, 52);
            this.MK_59153_Up.TabIndex = 1;
            this.MK_59153_Up.Text = "Up";
            this.MK_59153_Up.UseVisualStyleBackColor = true;
            this.MK_59153_Up.Click += new System.EventHandler(this.MK_59153_Up_Click);
            // 
            // MK_59153_UpRight
            // 
            this.MK_59153_UpRight.Location = new System.Drawing.Point(185, 12);
            this.MK_59153_UpRight.Name = "MK_59153_UpRight";
            this.MK_59153_UpRight.Size = new System.Drawing.Size(75, 52);
            this.MK_59153_UpRight.TabIndex = 2;
            this.MK_59153_UpRight.Text = "UpRight";
            this.MK_59153_UpRight.UseVisualStyleBackColor = true;
            this.MK_59153_UpRight.Click += new System.EventHandler(this.MK_59153_UpRight_Click);
            // 
            // MK_59153_Left
            // 
            this.MK_59153_Left.Location = new System.Drawing.Point(23, 70);
            this.MK_59153_Left.Name = "MK_59153_Left";
            this.MK_59153_Left.Size = new System.Drawing.Size(75, 52);
            this.MK_59153_Left.TabIndex = 3;
            this.MK_59153_Left.Text = "Left";
            this.MK_59153_Left.UseVisualStyleBackColor = true;
            this.MK_59153_Left.Click += new System.EventHandler(this.MK_59153_Left_Click);
            // 
            // MK_59153_SizeUp
            // 
            this.MK_59153_SizeUp.Location = new System.Drawing.Point(104, 70);
            this.MK_59153_SizeUp.Name = "MK_59153_SizeUp";
            this.MK_59153_SizeUp.Size = new System.Drawing.Size(75, 23);
            this.MK_59153_SizeUp.TabIndex = 4;
            this.MK_59153_SizeUp.Text = "SizeUp";
            this.MK_59153_SizeUp.UseVisualStyleBackColor = true;
            this.MK_59153_SizeUp.Click += new System.EventHandler(this.MK_59153_SizeUp_Click);
            // 
            // MK_59153_Right
            // 
            this.MK_59153_Right.Location = new System.Drawing.Point(185, 70);
            this.MK_59153_Right.Name = "MK_59153_Right";
            this.MK_59153_Right.Size = new System.Drawing.Size(75, 52);
            this.MK_59153_Right.TabIndex = 5;
            this.MK_59153_Right.Text = "Right";
            this.MK_59153_Right.UseVisualStyleBackColor = true;
            this.MK_59153_Right.Click += new System.EventHandler(this.MK_59153_Right_Click);
            // 
            // MK_59153_DownLeft
            // 
            this.MK_59153_DownLeft.Location = new System.Drawing.Point(23, 128);
            this.MK_59153_DownLeft.Name = "MK_59153_DownLeft";
            this.MK_59153_DownLeft.Size = new System.Drawing.Size(75, 52);
            this.MK_59153_DownLeft.TabIndex = 6;
            this.MK_59153_DownLeft.Text = "DownLeft";
            this.MK_59153_DownLeft.UseVisualStyleBackColor = true;
            this.MK_59153_DownLeft.Click += new System.EventHandler(this.MK_59153_DownLeft_Click);
            // 
            // MK_59153_Down
            // 
            this.MK_59153_Down.Location = new System.Drawing.Point(104, 128);
            this.MK_59153_Down.Name = "MK_59153_Down";
            this.MK_59153_Down.Size = new System.Drawing.Size(75, 52);
            this.MK_59153_Down.TabIndex = 7;
            this.MK_59153_Down.Text = "Down";
            this.MK_59153_Down.UseVisualStyleBackColor = true;
            this.MK_59153_Down.Click += new System.EventHandler(this.MK_59153_Down_Click);
            // 
            // MK_59153_DownRight
            // 
            this.MK_59153_DownRight.Location = new System.Drawing.Point(185, 128);
            this.MK_59153_DownRight.Name = "MK_59153_DownRight";
            this.MK_59153_DownRight.Size = new System.Drawing.Size(75, 52);
            this.MK_59153_DownRight.TabIndex = 8;
            this.MK_59153_DownRight.Text = "DownRight";
            this.MK_59153_DownRight.UseVisualStyleBackColor = true;
            this.MK_59153_DownRight.Click += new System.EventHandler(this.MK_59153_DownRight_Click);
            // 
            // MK_59153_Box
            // 
            this.MK_59153_Box.BackColor = System.Drawing.Color.Black;
            this.MK_59153_Box.Location = new System.Drawing.Point(34, 12);
            this.MK_59153_Box.MaximumSize = new System.Drawing.Size(500, 500);
            this.MK_59153_Box.Name = "MK_59153_Box";
            this.MK_59153_Box.Size = new System.Drawing.Size(20, 20);
            this.MK_59153_Box.TabIndex = 9;
            this.MK_59153_Box.Text = "BOX";
            // 
            // MK_59153_SizeDown
            // 
            this.MK_59153_SizeDown.Location = new System.Drawing.Point(104, 99);
            this.MK_59153_SizeDown.Name = "MK_59153_SizeDown";
            this.MK_59153_SizeDown.Size = new System.Drawing.Size(75, 23);
            this.MK_59153_SizeDown.TabIndex = 10;
            this.MK_59153_SizeDown.Text = "SizeDown";
            this.MK_59153_SizeDown.UseVisualStyleBackColor = true;
            this.MK_59153_SizeDown.Click += new System.EventHandler(this.MK_59153_SizeDown_Click);
            // 
            // MK_59153_panel
            // 
            this.MK_59153_panel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MK_59153_panel.Controls.Add(this.MK_59153_Box);
            this.MK_59153_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MK_59153_panel.Location = new System.Drawing.Point(309, 0);
            this.MK_59153_panel.Name = "MK_59153_panel";
            this.MK_59153_panel.Size = new System.Drawing.Size(500, 500);
            this.MK_59153_panel.TabIndex = 11;
            // 
            // MK_59153_instructionW
            // 
            this.MK_59153_instructionW.BackColor = System.Drawing.Color.LightCoral;
            this.MK_59153_instructionW.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MK_59153_instructionW.Location = new System.Drawing.Point(23, 245);
            this.MK_59153_instructionW.Name = "MK_59153_instructionW";
            this.MK_59153_instructionW.Size = new System.Drawing.Size(237, 21);
            this.MK_59153_instructionW.TabIndex = 12;
            this.MK_59153_instructionW.Text = "W - move up";
            // 
            // MK_59153_instructionE
            // 
            this.MK_59153_instructionE.BackColor = System.Drawing.Color.LightCoral;
            this.MK_59153_instructionE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MK_59153_instructionE.Location = new System.Drawing.Point(23, 270);
            this.MK_59153_instructionE.Name = "MK_59153_instructionE";
            this.MK_59153_instructionE.Size = new System.Drawing.Size(237, 21);
            this.MK_59153_instructionE.TabIndex = 13;
            this.MK_59153_instructionE.Text = "E - move up right";
            // 
            // MK_59153_instructionD
            // 
            this.MK_59153_instructionD.BackColor = System.Drawing.Color.LightCoral;
            this.MK_59153_instructionD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MK_59153_instructionD.Location = new System.Drawing.Point(23, 295);
            this.MK_59153_instructionD.Name = "MK_59153_instructionD";
            this.MK_59153_instructionD.Size = new System.Drawing.Size(237, 21);
            this.MK_59153_instructionD.TabIndex = 14;
            this.MK_59153_instructionD.Text = "D - move right";
            // 
            // MK_59153_instructionC
            // 
            this.MK_59153_instructionC.BackColor = System.Drawing.Color.LightCoral;
            this.MK_59153_instructionC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MK_59153_instructionC.Location = new System.Drawing.Point(23, 320);
            this.MK_59153_instructionC.Name = "MK_59153_instructionC";
            this.MK_59153_instructionC.Size = new System.Drawing.Size(237, 21);
            this.MK_59153_instructionC.TabIndex = 15;
            this.MK_59153_instructionC.Text = "C - move down right";
            // 
            // MK_59153_instructionS
            // 
            this.MK_59153_instructionS.BackColor = System.Drawing.Color.LightCoral;
            this.MK_59153_instructionS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MK_59153_instructionS.Location = new System.Drawing.Point(23, 345);
            this.MK_59153_instructionS.Name = "MK_59153_instructionS";
            this.MK_59153_instructionS.Size = new System.Drawing.Size(237, 21);
            this.MK_59153_instructionS.TabIndex = 16;
            this.MK_59153_instructionS.Text = "S - move down";
            // 
            // MK_59153_instructionZ
            // 
            this.MK_59153_instructionZ.BackColor = System.Drawing.Color.LightCoral;
            this.MK_59153_instructionZ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MK_59153_instructionZ.Location = new System.Drawing.Point(23, 370);
            this.MK_59153_instructionZ.Name = "MK_59153_instructionZ";
            this.MK_59153_instructionZ.Size = new System.Drawing.Size(237, 21);
            this.MK_59153_instructionZ.TabIndex = 17;
            this.MK_59153_instructionZ.Text = "Z - move down left";
            // 
            // MK_59153_instructionA
            // 
            this.MK_59153_instructionA.BackColor = System.Drawing.Color.LightCoral;
            this.MK_59153_instructionA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MK_59153_instructionA.Location = new System.Drawing.Point(23, 395);
            this.MK_59153_instructionA.Name = "MK_59153_instructionA";
            this.MK_59153_instructionA.Size = new System.Drawing.Size(237, 21);
            this.MK_59153_instructionA.TabIndex = 18;
            this.MK_59153_instructionA.Text = "A - move left";
            // 
            // MK_59153_instructionQ
            // 
            this.MK_59153_instructionQ.BackColor = System.Drawing.Color.LightCoral;
            this.MK_59153_instructionQ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MK_59153_instructionQ.Location = new System.Drawing.Point(23, 420);
            this.MK_59153_instructionQ.Name = "MK_59153_instructionQ";
            this.MK_59153_instructionQ.Size = new System.Drawing.Size(237, 21);
            this.MK_59153_instructionQ.TabIndex = 19;
            this.MK_59153_instructionQ.Text = "Q - move up left";
            // 
            // MK_59153_instructionSizeUp
            // 
            this.MK_59153_instructionSizeUp.BackColor = System.Drawing.Color.LightCoral;
            this.MK_59153_instructionSizeUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MK_59153_instructionSizeUp.Location = new System.Drawing.Point(23, 445);
            this.MK_59153_instructionSizeUp.Name = "MK_59153_instructionSizeUp";
            this.MK_59153_instructionSizeUp.Size = new System.Drawing.Size(237, 21);
            this.MK_59153_instructionSizeUp.TabIndex = 20;
            this.MK_59153_instructionSizeUp.Text = "\"+\" - size up";
            // 
            // MK_59153_instructionSizeDown
            // 
            this.MK_59153_instructionSizeDown.BackColor = System.Drawing.Color.LightCoral;
            this.MK_59153_instructionSizeDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MK_59153_instructionSizeDown.Location = new System.Drawing.Point(23, 470);
            this.MK_59153_instructionSizeDown.Name = "MK_59153_instructionSizeDown";
            this.MK_59153_instructionSizeDown.Size = new System.Drawing.Size(237, 21);
            this.MK_59153_instructionSizeDown.TabIndex = 21;
            this.MK_59153_instructionSizeDown.Text = "\"-\" - size down";
            // 
            // MK_59153_legend
            // 
            this.MK_59153_legend.BackColor = System.Drawing.SystemColors.Desktop;
            this.MK_59153_legend.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MK_59153_legend.ForeColor = System.Drawing.Color.Orange;
            this.MK_59153_legend.Location = new System.Drawing.Point(23, 210);
            this.MK_59153_legend.Name = "MK_59153_legend";
            this.MK_59153_legend.Size = new System.Drawing.Size(237, 31);
            this.MK_59153_legend.TabIndex = 22;
            this.MK_59153_legend.Text = "Legend";
            this.MK_59153_legend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MK_59153_form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 500);
            this.Controls.Add(this.MK_59153_legend);
            this.Controls.Add(this.MK_59153_instructionSizeDown);
            this.Controls.Add(this.MK_59153_instructionSizeUp);
            this.Controls.Add(this.MK_59153_instructionQ);
            this.Controls.Add(this.MK_59153_instructionA);
            this.Controls.Add(this.MK_59153_instructionZ);
            this.Controls.Add(this.MK_59153_instructionS);
            this.Controls.Add(this.MK_59153_instructionC);
            this.Controls.Add(this.MK_59153_instructionD);
            this.Controls.Add(this.MK_59153_instructionE);
            this.Controls.Add(this.MK_59153_instructionW);
            this.Controls.Add(this.MK_59153_panel);
            this.Controls.Add(this.MK_59153_SizeDown);
            this.Controls.Add(this.MK_59153_DownRight);
            this.Controls.Add(this.MK_59153_Down);
            this.Controls.Add(this.MK_59153_DownLeft);
            this.Controls.Add(this.MK_59153_Right);
            this.Controls.Add(this.MK_59153_SizeUp);
            this.Controls.Add(this.MK_59153_Left);
            this.Controls.Add(this.MK_59153_UpRight);
            this.Controls.Add(this.MK_59153_Up);
            this.Controls.Add(this.MK_59153_UpLeft);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 539);
            this.MinimumSize = new System.Drawing.Size(780, 539);
            this.Name = "MK_59153_form1";
            this.Text = "MK_59153_form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MK_59153_form1_KeyDown);
            this.MK_59153_panel.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion
        //Utworzenie funkcji do obsługi każdego przycisku poruszania  
        //Każdy przycisk przesuwa nasz kwadrat o 5 pixeli 
        //po czym sprawdza, czy wyszedł poza obszar, w którym może się poruszać
        //jeżeli kwadrat wyszedł chociaż częściowo, to odpowiednio zostaje ustawiony tak, żeby pozostał w obszarze
        #region button clicks
        private void MK_59153_Up_Click(object sender, EventArgs e)
        {
            //zmiana pozycji
            MK_59153_Box.Location = new Point(MK_59153_Box.Location.X, MK_59153_Box.Location.Y - MK_59153_amountOfPixelsToMove);
            //poprawienie pozycji w razie wyjścia za obszar
            if (MK_59153_Box.Location.Y < 0)
            {
                MK_59153_Box.Location = new Point(MK_59153_Box.Location.X, 0);
            }
        }

        private void MK_59153_UpRight_Click(object sender, EventArgs e)
        {
            //zmiana pozycji
            MK_59153_Box.Location = new Point(MK_59153_Box.Location.X + MK_59153_amountOfPixelsToMove, MK_59153_Box.Location.Y - MK_59153_amountOfPixelsToMove);
            //poprawienie pozycji w razie wyjścia za obszar
            //najpierw sprawdza, czy kwadrat wyszedł za obszar na dwóch krawędziach
            //a dopiero potem czy na górnej czy na prawej
            if (MK_59153_Box.Location.Y < 0 && MK_59153_Box.Location.X + MK_59153_Box.Size.Width > MK_59153_panel.Size.Width)
            {
                MK_59153_Box.Location = new Point(MK_59153_panel.Size.Width - MK_59153_Box.Size.Width, 0);
            }
            else if(MK_59153_Box.Location.Y < 0)
            {
                MK_59153_Box.Location = new Point(MK_59153_Box.Location.X, 0);
            }
            else if(MK_59153_Box.Location.X + MK_59153_Box.Size.Width > MK_59153_panel.Size.Width)
            {
                MK_59153_Box.Location = new Point(MK_59153_panel.Size.Width - MK_59153_Box.Size.Width, MK_59153_Box.Location.Y);
            }
        }

        private void MK_59153_Right_Click(object sender, EventArgs e)
        {
            //zmiana pozycji
            MK_59153_Box.Location = new Point(MK_59153_Box.Location.X + MK_59153_amountOfPixelsToMove, MK_59153_Box.Location.Y);
            //poprawienie pozycji w razie wyjścia za obszar
            if (MK_59153_Box.Location.X + MK_59153_Box.Size.Width > MK_59153_panel.Size.Width)
            {
                MK_59153_Box.Location = new Point(MK_59153_panel.Size.Width - MK_59153_Box.Size.Width, MK_59153_Box.Location.Y);
            }
        }

        private void MK_59153_DownRight_Click(object sender, EventArgs e)
        {
            //zmiana pozycji
            MK_59153_Box.Location = new Point(MK_59153_Box.Location.X + MK_59153_amountOfPixelsToMove, MK_59153_Box.Location.Y + MK_59153_amountOfPixelsToMove);
            //poprawienie pozycji w razie wyjścia za obszar
            //najpierw sprawdza się, czy kwadrat wyszedł za obszar na dwóch krawędziach
            //a potem dopiero czy na dolnej czy prawej
            if (MK_59153_Box.Location.Y + MK_59153_Box.Height > MK_59153_panel.Height && MK_59153_Box.Location.X + MK_59153_Box.Size.Width > MK_59153_panel.Size.Width)
            {
                MK_59153_Box.Location = new Point(MK_59153_panel.Size.Width - MK_59153_Box.Size.Width, MK_59153_panel.Height - MK_59153_Box.Height);
            }
            else if (MK_59153_Box.Location.Y + MK_59153_Box.Height > MK_59153_panel.Height)
            {
                MK_59153_Box.Location = new Point(MK_59153_Box.Location.X, MK_59153_panel.Size.Height - MK_59153_Box.Size.Height);
            }
            else if (MK_59153_Box.Location.X + MK_59153_Box.Size.Width > MK_59153_panel.Size.Width)
            {
                MK_59153_Box.Location = new Point(MK_59153_panel.Size.Width - MK_59153_Box.Size.Width, MK_59153_Box.Location.Y);
            }
        }

        private void MK_59153_Down_Click(object sender, EventArgs e)
        {
            //zmiana pozycji
            MK_59153_Box.Location = new Point(MK_59153_Box.Location.X, MK_59153_Box.Location.Y + MK_59153_amountOfPixelsToMove);
            //poprawienie pozycji w razie wyjścia za obszar
            if (MK_59153_Box.Location.Y + MK_59153_Box.Height > MK_59153_panel.Height)
            {
                MK_59153_Box.Location = new Point(MK_59153_Box.Location.X, MK_59153_panel.Height - MK_59153_Box.Height);
            }
        }

        private void MK_59153_DownLeft_Click(object sender, EventArgs e)
        {
            //zmiana pozycji
            MK_59153_Box.Location = new Point(MK_59153_Box.Location.X - MK_59153_amountOfPixelsToMove, MK_59153_Box.Location.Y + MK_59153_amountOfPixelsToMove);
            //poprawienie pozycji w razie wyjścia za obszar
            //najpierw sprawdza się, czy kwadrat wyszedł za obszar na dwóch krawędziach
            //a potem dopiero czy na dolnej czy na lewej
            if (MK_59153_Box.Location.Y + MK_59153_Box.Height > MK_59153_panel.Height && MK_59153_Box.Location.X < 0)
            {
                MK_59153_Box.Location = new Point(0, MK_59153_panel.Height - MK_59153_Box.Height);
            }
            else if (MK_59153_Box.Location.Y + MK_59153_Box.Height > MK_59153_panel.Height)
            {
                MK_59153_Box.Location = new Point(MK_59153_Box.Location.X, MK_59153_panel.Size.Height - MK_59153_Box.Size.Height);
            }
            else if (MK_59153_Box.Location.X < 0)
            {
                MK_59153_Box.Location = new Point(0, MK_59153_Box.Location.Y);
            }
        }

        private void MK_59153_Left_Click(object sender, EventArgs e)
        {
            //zmiana pozycji
            MK_59153_Box.Location = new Point(MK_59153_Box.Location.X - MK_59153_amountOfPixelsToMove, MK_59153_Box.Location.Y);
            //poprawienie pozycji w razie wyjścia za obszar
            if (MK_59153_Box.Location.X < 0)
            {
                MK_59153_Box.Location = new Point(0, MK_59153_Box.Location.Y);
            }
        }

        private void MK_59153_UpLeft_Click(object sender, EventArgs e)
        {
            //zmiana pozycji
            MK_59153_Box.Location = new Point(MK_59153_Box.Location.X - MK_59153_amountOfPixelsToMove, MK_59153_Box.Location.Y - MK_59153_amountOfPixelsToMove);
            //poprawienie pozycji w razie wyjścia za obszar
            //najpierw sprawdza się, czy kwadrat wyszedł za obszar na dwóch krawędziach
            //a potem dopiero czy na górnej czy lewej
            if (MK_59153_Box.Location.Y < 0 && MK_59153_Box.Location.X < 0)
            {
                MK_59153_Box.Location = new Point(0, 0);
            }
            else if (MK_59153_Box.Location.Y < 0)
            {
                MK_59153_Box.Location = new Point(MK_59153_Box.Location.X, 0);
            }
            else if (MK_59153_Box.Location.X < 0)
            {
                MK_59153_Box.Location = new Point(0, MK_59153_Box.Location.Y);
            }
        }
        #endregion

        //Utworzenie dwóch funkcji do zmiany wielkości naszego kwadratu
        //funkcje zwiększają bądź zmniejszają kwadrat o 4 pixele
        //powiększenie jak i pomniejszenie działa centrycznie
        //dodatkowo przy powiększaniu kiedy kwadrat wyszedłby za obszar, również jego pozycja zostaje poprawiona
        #region powiększenie i pomniejszenie
        private void MK_59153_SizeUp_Click(object sender, EventArgs e)
        {
            //zwiększenie kwadratu
            MK_59153_Box.Size = new Size(MK_59153_Box.Size.Width + MK_59153_resizeAmount, MK_59153_Box.Size.Height + MK_59153_resizeAmount);
            //wycentrowanie kwadratu względem samego siebie po jego powiększeniu
            MK_59153_Box.Location = new Point(MK_59153_Box.Location.X - MK_59153_resizeAmount / 2, MK_59153_Box.Location.Y - MK_59153_resizeAmount / 2);
            //poprawienie pozycji w razie wyjścia za obszar
            if (MK_59153_Box.Location.Y < 0)
            {
                MK_59153_Box.Location = new Point(MK_59153_Box.Location.X, 0);
            }
            if(MK_59153_Box.Location.X < 0)
            {
                MK_59153_Box.Location = new Point(0, MK_59153_Box.Location.Y);
            }
            if (MK_59153_Box.Location.X + MK_59153_Box.Size.Width > MK_59153_panel.Size.Width)
            {
                MK_59153_Box.Location = new Point(MK_59153_panel.Size.Width - MK_59153_Box.Size.Width, MK_59153_Box.Location.Y);
            }
            if (MK_59153_Box.Location.Y + MK_59153_Box.Height > MK_59153_panel.Height)
            {
                MK_59153_Box.Location = new Point(MK_59153_Box.Location.X, MK_59153_panel.Height - MK_59153_Box.Height);
            }
        }
        private void MK_59153_SizeDown_Click(object sender, EventArgs e)
        {
            //zmniejszenie kwadratu
            MK_59153_Box.Size = new Size(MK_59153_Box.Size.Width - MK_59153_resizeAmount, MK_59153_Box.Size.Height - MK_59153_resizeAmount);
            //wycentrowanie kwadratu względem samego siebie po jego zmniejszeniu
            MK_59153_Box.Location = new Point(MK_59153_Box.Location.X + MK_59153_resizeAmount / 2, MK_59153_Box.Location.Y + MK_59153_resizeAmount / 2);
        }
        #endregion

        //obsługa klawiaturą
        //przy zdarzeniu keyDown sprawdzam jaki przycisk został wciśnięty i przyzywam odpowienią metodę
        private void MK_59153_form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    MK_59153_Up.PerformClick();
                    break;
                case Keys.E:
                    MK_59153_UpRight.PerformClick();
                    break;
                case Keys.D:
                    MK_59153_Right.PerformClick();
                    break;
                case Keys.C:
                    MK_59153_DownRight.PerformClick();
                    break;
                case Keys.S:
                    MK_59153_Down.PerformClick();
                    break;
                case Keys.Z:
                    MK_59153_DownLeft.PerformClick();
                    break;
                case Keys.A:
                    MK_59153_Left.PerformClick();
                    break;
                case Keys.Q:
                    MK_59153_UpLeft.PerformClick();
                    break;
                case Keys.Oemplus:
                    MK_59153_SizeUp.PerformClick();
                    break;
                case Keys.OemMinus:
                    MK_59153_SizeDown.PerformClick();
                    break;
            }
        }
    }
}
