﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CegalaStudio.Model;

namespace CegalaStudio
{
    public partial class Form1 : Form
    {
        private WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public List<Record> recordsList;

        public Form1(List<Record> records)
        {
            InitializeComponent();           
            stopButton.Enabled = false;
            nextButton.Enabled = false;
            this.recordsList = records;
            initializeRecordDataGridView();
            initializePlayer();
        }

        private void initializeRecordDataGridView()
        {
            recordDataGridView.DataSource = this.recordsList;

            recordDataGridView.MultiSelect = false;
            recordDataGridView.AllowUserToAddRows = false;
            recordDataGridView.AllowUserToDeleteRows = false;
            recordDataGridView.AllowUserToOrderColumns = false;
            recordDataGridView.AllowUserToResizeColumns = false;
            recordDataGridView.AllowUserToResizeRows = false;
            recordDataGridView.ReadOnly = true;
            triggerTextBox.ReadOnly = true;
        }

        private void recordDataGridView_SelectionChanged(object sender, EventArgs args)
        {
            DataGridView gridView = (DataGridView)sender;
            int curIndex = gridView.SelectedRows[0].Index;
            displayTrigger(curIndex);
        }

        private void initializePlayer()
        {
            wplayer.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(wplayer_PlayStateChange);
        }

        private void playMusic(string path)
        {
            nextButton.Enabled = false;
            wplayer.URL = path;
            //wplayer.controls.play();
        }

        private void wplayer_PlayStateChange(int NewState)
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                wplayer.close();
                int curIndex = recordDataGridView.SelectedRows[0].Index;

                if (curIndex + 1 < recordDataGridView.RowCount)
                {
                    recordDataGridView.Rows[curIndex + 1].Selected = true;
                    nextButton.Enabled = true;
                }
                else
                {
                    startButton.Enabled = true;
                    stopButton.Enabled = false;
                    nextButton.Enabled = false;
                    recordDataGridView.Rows[0].Selected = true;
                }
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            string path = (string)recordDataGridView.SelectedRows[0].Cells[2].Value;
            playMusic(path);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            recordDataGridView.SelectionChanged += recordDataGridView_SelectionChanged;
            startButton.Enabled = false;
            stopButton.Enabled = true;
            nextButton.Enabled = true;
            recordDataGridView.Enabled = false;
            recordDataGridView.Rows[0].Selected = true;
            displayTrigger(0);
        }

        private void displayTrigger(int index)
        {
            string triggerValue = this.recordsList[index].Declencheur;
            triggerTextBox.Clear();
            triggerTextBox.Text = triggerValue;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            wplayer.close();
            startButton.Enabled = true;
            stopButton.Enabled = false;
            nextButton.Enabled = false;
            recordDataGridView.Rows[0].Selected = true;
        }
    }
}