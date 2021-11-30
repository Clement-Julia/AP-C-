using AP.dtos;
using AP.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP.Forms
{
    public partial class AjoutHebergement : Form
    {
        private ApiGouvCommunes _apiGouvCommunes;
        private List<ApiCommuneDto> _listeCommunes = new List<ApiCommuneDto>();
        private int number = 2;
        public AjoutHebergement()
        {
            InitializeComponent();
            this._apiGouvCommunes = new ApiGouvCommunes();
        }

        private async void inputCommune_TextChanged(object sender, EventArgs e)
        {
            comboBoxCommune.Items.Clear();
            _listeCommunes.Clear();

            var cancellationTokenSource = new CancellationTokenSource();

            if (this.number != 2)
                cancellationTokenSource.Cancel();
            await Task.Delay(1000).ContinueWith((task) => { this.number--; });

            if (int.TryParse(inputCommune.Text, out int number) && number.ToString().Length > 4 )
            {
                _listeCommunes = await _apiGouvCommunes.ListeCommunes(number);
                var test = _listeCommunes.Where(w => w.codeRegion == _apiGouvCommunes._listeNosRegions.Where(s => s.code == w.codeRegion).Select(v => v.code).ToString());
                if (comboBoxCommune.Items.Count > test.Count())
                {
                    comboBoxCommune.Items.Clear();
                }
                foreach (ApiCommuneDto item in _listeCommunes)
                {
                    if (_apiGouvCommunes._listeNosRegions.Where(w => w.code == item.codeRegion).FirstOrDefault() != null)
                    {
                        string comboItem = item.nom;
                        comboBoxCommune.Items.Add(comboItem);
                    }
                }
                this.number = 2;
            }
            else
            {
                _listeCommunes = await _apiGouvCommunes.ListeCommunes(inputCommune.Text);
                var test = _listeCommunes.Where(w => w.codeRegion == _apiGouvCommunes._listeNosRegions.Where(s => s.code == w.codeRegion).Select(v => v.code).ToString());
                if (comboBoxCommune.Items.Count > test.Count())
                {
                    comboBoxCommune.Items.Clear();
                }
                foreach (ApiCommuneDto item in _listeCommunes)
                {
                    if(_apiGouvCommunes._listeNosRegions.Where(w => w.code == item.codeRegion).FirstOrDefault() != null)
                    {
                        string comboItem = item.nom;
                        comboBoxCommune.Items.Add(comboItem);
                    }
                }
                this.number = 2;
            }
            test.Text = this.number.ToString();
        }

    }
}
