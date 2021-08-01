using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Win32;

namespace GTAV_LanguageChanger
{

    public partial class Form1 : Form
    {
        public static string GetKeyFromValue(Dictionary<string, string> dictionaryVar, string valueVar)
        {
            foreach (string keyVar in dictionaryVar.Keys)
            {
                if (dictionaryVar[keyVar] == valueVar)
                {
                    return keyVar;
                }
            }
            return null;
        }

        readonly Dictionary<string, string> languages = new Dictionary<string, string>
        {
            { "de-DE", "German" },
            { "en-US", "English" },
            { "es-ES", "Spanish" },
            { "es-MX", "Mexican Spanish" },
            { "fr-FR", "French" },
            { "it-IT", "Italian" },
            { "ja-JP", "Japanese" },
            { "ko-KR", "Korean" },
            { "pl-PL", "Polish" },
            { "pt-BR", "Brazillian Portugese" },
            { "ru-RU", "Russian" },
            { "zh-CN", "Simplified Chinese (China)" },
            { "zh-TW", "Traditional Chinese (Taiwan)" }
        };

        static string RegKeyLoc = "SOFTWARE\\WOW6432Node\\Rockstar Games\\Grand Theft Auto V";

        RegistryKey localMachine = RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry64);

        public Form1()
        {
            InitializeComponent();

            var RegKey = localMachine.OpenSubKey(RegKeyLoc);
            if (RegKey != null)
            {
                if (RegKey.GetValue("Language") != null)
                {
                    string lang = languages[RegKey.GetValue("Language").ToString()];
                    CurrentLang.Text = lang;
                }

                else
                {
                    CurrentLang.Text = "No language set in registry";
                }
            }
            else
            {
                localMachine.CreateSubKey(RegKeyLoc);
                CurrentLang.Text = "No language set in registry";
            }

            foreach (var lang in languages)
            {
                LangList.Items.Add(lang.Value);
            }

            LangList.SelectedItem = "English";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var RegKey = localMachine.OpenSubKey(RegKeyLoc, true);
            if (RegKey != null)
            {
                RegKey.SetValue("Language", GetKeyFromValue(languages, LangList.SelectedItem.ToString()));
                CurrentLang.Text = LangList.SelectedItem.ToString();
            }
            else
            {
                RegKey.SetValue("Language", GetKeyFromValue(languages, LangList.SelectedItem.ToString()));
                CurrentLang.Text = LangList.SelectedItem.ToString();
            }
        }
    }
}
