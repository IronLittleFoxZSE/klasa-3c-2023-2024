﻿namespace NotepadWinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStripMainMenu = new MenuStrip();
            plikToolStripMenuItem = new ToolStripMenuItem();
            nowyToolStripMenuItem = new ToolStripMenuItem();
            otwórzToolStripMenuItem = new ToolStripMenuItem();
            zapiszToolStripMenuItem = new ToolStripMenuItem();
            zapiszJakoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            zamknijToolStripMenuItem = new ToolStripMenuItem();
            edycjaToolStripMenuItem = new ToolStripMenuItem();
            cofnijToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            wytnijToolStripMenuItem = new ToolStripMenuItem();
            kopiujToolStripMenuItem = new ToolStripMenuItem();
            wklejToolStripMenuItem = new ToolStripMenuItem();
            usuńToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            zaznaczWszystkoToolStripMenuItem = new ToolStripMenuItem();
            datagodzinaToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            widokToolStripMenuItem = new ToolStripMenuItem();
            pomocToolStripMenuItem = new ToolStripMenuItem();
            textBoxNotepad = new TextBox();
            statusStripInfo = new StatusStrip();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            oProgramieToolStripMenuItem = new ToolStripMenuItem();
            menuStripMainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMainMenu
            // 
            menuStripMainMenu.Items.AddRange(new ToolStripItem[] { plikToolStripMenuItem, edycjaToolStripMenuItem, formatToolStripMenuItem, widokToolStripMenuItem, pomocToolStripMenuItem });
            menuStripMainMenu.Location = new Point(0, 0);
            menuStripMainMenu.Name = "menuStripMainMenu";
            menuStripMainMenu.Size = new Size(849, 24);
            menuStripMainMenu.TabIndex = 0;
            menuStripMainMenu.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            plikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nowyToolStripMenuItem, otwórzToolStripMenuItem, zapiszToolStripMenuItem, zapiszJakoToolStripMenuItem, toolStripMenuItem1, zamknijToolStripMenuItem });
            plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            plikToolStripMenuItem.Size = new Size(38, 20);
            plikToolStripMenuItem.Text = "&Plik";
            // 
            // nowyToolStripMenuItem
            // 
            nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            nowyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            nowyToolStripMenuItem.Size = new Size(216, 22);
            nowyToolStripMenuItem.Text = "Nowy";
            nowyToolStripMenuItem.Click += nowyToolStripMenuItem_Click;
            // 
            // otwórzToolStripMenuItem
            // 
            otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            otwórzToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            otwórzToolStripMenuItem.Size = new Size(216, 22);
            otwórzToolStripMenuItem.Text = "Otwórz";
            otwórzToolStripMenuItem.Click += otwórzToolStripMenuItem_Click;
            // 
            // zapiszToolStripMenuItem
            // 
            zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            zapiszToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            zapiszToolStripMenuItem.Size = new Size(216, 22);
            zapiszToolStripMenuItem.Text = "Zapi&sz";
            zapiszToolStripMenuItem.Click += zapiszToolStripMenuItem_Click;
            // 
            // zapiszJakoToolStripMenuItem
            // 
            zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            zapiszJakoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            zapiszJakoToolStripMenuItem.Size = new Size(216, 22);
            zapiszJakoToolStripMenuItem.Text = "Zapisz jako ...";
            zapiszJakoToolStripMenuItem.Click += zapiszJakoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(213, 6);
            // 
            // zamknijToolStripMenuItem
            // 
            zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            zamknijToolStripMenuItem.Size = new Size(216, 22);
            zamknijToolStripMenuItem.Text = "Zamknij";
            zamknijToolStripMenuItem.Click += zamknijToolStripMenuItem_Click;
            // 
            // edycjaToolStripMenuItem
            // 
            edycjaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cofnijToolStripMenuItem, toolStripMenuItem2, wytnijToolStripMenuItem, kopiujToolStripMenuItem, wklejToolStripMenuItem, usuńToolStripMenuItem, toolStripMenuItem3, zaznaczWszystkoToolStripMenuItem, datagodzinaToolStripMenuItem });
            edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            edycjaToolStripMenuItem.Size = new Size(53, 20);
            edycjaToolStripMenuItem.Text = "&Edycja";
            // 
            // cofnijToolStripMenuItem
            // 
            cofnijToolStripMenuItem.Name = "cofnijToolStripMenuItem";
            cofnijToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            cofnijToolStripMenuItem.Size = new Size(204, 22);
            cofnijToolStripMenuItem.Text = "Cofnij";
            cofnijToolStripMenuItem.Click += cofnijToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(201, 6);
            // 
            // wytnijToolStripMenuItem
            // 
            wytnijToolStripMenuItem.Name = "wytnijToolStripMenuItem";
            wytnijToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            wytnijToolStripMenuItem.Size = new Size(204, 22);
            wytnijToolStripMenuItem.Text = "Wytnij";
            wytnijToolStripMenuItem.Click += wytnijToolStripMenuItem_Click;
            // 
            // kopiujToolStripMenuItem
            // 
            kopiujToolStripMenuItem.Name = "kopiujToolStripMenuItem";
            kopiujToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            kopiujToolStripMenuItem.Size = new Size(204, 22);
            kopiujToolStripMenuItem.Text = "Kopiuj";
            kopiujToolStripMenuItem.Click += kopiujToolStripMenuItem_Click;
            // 
            // wklejToolStripMenuItem
            // 
            wklejToolStripMenuItem.Name = "wklejToolStripMenuItem";
            wklejToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            wklejToolStripMenuItem.Size = new Size(204, 22);
            wklejToolStripMenuItem.Text = "Wklej";
            wklejToolStripMenuItem.Click += wklejToolStripMenuItem_Click;
            // 
            // usuńToolStripMenuItem
            // 
            usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            usuńToolStripMenuItem.ShortcutKeys = Keys.Delete;
            usuńToolStripMenuItem.Size = new Size(204, 22);
            usuńToolStripMenuItem.Text = "Usuń";
            usuńToolStripMenuItem.Click += usuńToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(201, 6);
            // 
            // zaznaczWszystkoToolStripMenuItem
            // 
            zaznaczWszystkoToolStripMenuItem.Name = "zaznaczWszystkoToolStripMenuItem";
            zaznaczWszystkoToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.A;
            zaznaczWszystkoToolStripMenuItem.Size = new Size(204, 22);
            zaznaczWszystkoToolStripMenuItem.Text = "Zaznacz wszystko";
            zaznaczWszystkoToolStripMenuItem.Click += zaznaczWszystkoToolStripMenuItem_Click;
            // 
            // datagodzinaToolStripMenuItem
            // 
            datagodzinaToolStripMenuItem.Name = "datagodzinaToolStripMenuItem";
            datagodzinaToolStripMenuItem.ShortcutKeys = Keys.F5;
            datagodzinaToolStripMenuItem.Size = new Size(204, 22);
            datagodzinaToolStripMenuItem.Text = "Data/godzina";
            datagodzinaToolStripMenuItem.Click += datagodzinaToolStripMenuItem_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(57, 20);
            formatToolStripMenuItem.Text = "Format";
            // 
            // widokToolStripMenuItem
            // 
            widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            widokToolStripMenuItem.Size = new Size(53, 20);
            widokToolStripMenuItem.Text = "Widok";
            // 
            // pomocToolStripMenuItem
            // 
            pomocToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oProgramieToolStripMenuItem });
            pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            pomocToolStripMenuItem.Size = new Size(57, 20);
            pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // textBoxNotepad
            // 
            textBoxNotepad.Dock = DockStyle.Fill;
            textBoxNotepad.Font = new Font("Segoe UI", 9F);
            textBoxNotepad.Location = new Point(0, 24);
            textBoxNotepad.Multiline = true;
            textBoxNotepad.Name = "textBoxNotepad";
            textBoxNotepad.Size = new Size(849, 494);
            textBoxNotepad.TabIndex = 1;
            textBoxNotepad.KeyDown += textBoxNotepad_KeyDown;
            textBoxNotepad.KeyUp += textBoxNotepad_KeyUp;
            // 
            // statusStripInfo
            // 
            statusStripInfo.Location = new Point(0, 518);
            statusStripInfo.Name = "statusStripInfo";
            statusStripInfo.Size = new Size(849, 22);
            statusStripInfo.TabIndex = 2;
            statusStripInfo.Text = "statusStrip1";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            openFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki|*.*";
            // 
            // saveFileDialog
            // 
            saveFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt";
            // 
            // oProgramieToolStripMenuItem
            // 
            oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            oProgramieToolStripMenuItem.Size = new Size(180, 22);
            oProgramieToolStripMenuItem.Text = "O programie";
            oProgramieToolStripMenuItem.Click += oProgramieToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 540);
            Controls.Add(textBoxNotepad);
            Controls.Add(statusStripInfo);
            Controls.Add(menuStripMainMenu);
            MainMenuStrip = menuStripMainMenu;
            Name = "MainForm";
            Text = "Notatnik";
            menuStripMainMenu.ResumeLayout(false);
            menuStripMainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMainMenu;
        private ToolStripMenuItem plikToolStripMenuItem;
        private ToolStripMenuItem nowyToolStripMenuItem;
        private ToolStripMenuItem otwórzToolStripMenuItem;
        private ToolStripMenuItem zapiszToolStripMenuItem;
        private ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private ToolStripMenuItem zamknijToolStripMenuItem;
        private ToolStripMenuItem edycjaToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem widokToolStripMenuItem;
        private ToolStripMenuItem pomocToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private TextBox textBoxNotepad;
        private StatusStrip statusStripInfo;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private ToolStripMenuItem cofnijToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem wytnijToolStripMenuItem;
        private ToolStripMenuItem kopiujToolStripMenuItem;
        private ToolStripMenuItem wklejToolStripMenuItem;
        private ToolStripMenuItem usuńToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem zaznaczWszystkoToolStripMenuItem;
        private ToolStripMenuItem datagodzinaToolStripMenuItem;
        private ToolStripMenuItem oProgramieToolStripMenuItem;
    }
}
