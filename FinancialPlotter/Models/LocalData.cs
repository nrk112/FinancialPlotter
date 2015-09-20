﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialPlotter.Interfaces;

namespace FinancialPlotter.Models
{
    class LocalData : IDataPlugin
    {

        public LocalData()
        {
            Queries = new List<IDailyQuery>();
        }

        public Form ControlForm
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Form OptionsForm
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public List<IDailyQuery> Queries { get; }

        public bool HasOptions
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Displays the open file dialog to select the csv file to use.
        /// </summary>
        public void LoadData()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            string fileName;

            openFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                ParseFile(fileName);
            }
        }

        /// <summary>
        /// Opens a csv file of financial data, turns it into a useable object and loads it into the list needed for the interface.
        /// </summary>
        /// <param name="fileName">The file to parse.</param>
        private void ParseFile(string fileName)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(fileName))
                {
                    List<string[]> lines = new List<string[]>();

                    //Skip the first line which is the header.
                    streamReader.ReadLine();

                    string[] query;
                    while (!streamReader.EndOfStream)
                    {
                        query = streamReader.ReadLine().Split(',');
                        Queries.Add(CreateDailyQuery(query));
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("There was an problem opening the file. Please try again.");
            }
        }

        /// <summary>
        /// Turns the data into a DailyQuery object required to plot the data.
        /// </summary>
        /// <param name="data">The raw data.</param>
        /// <returns>The daily query.</returns>
        private DailyQuery CreateDailyQuery(string[] data)
        {
            string[] stringDate = data[0].Split('-');
            DateTime date = new DateTime(
                Int32.Parse(stringDate[0]),
                Int32.Parse(stringDate[1]),
                Int32.Parse(stringDate[2]));

            DailyQuery dq = new DailyQuery(
                date,
                float.Parse(data[1]),
                float.Parse(data[2]),
                float.Parse(data[3]),
                float.Parse(data[4]),
                float.Parse(data[5])
                );
            return dq;
        }
    }


}
