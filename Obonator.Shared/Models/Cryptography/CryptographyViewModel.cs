using Microsoft.AspNetCore.Components;
using Obonator.Shared.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Liluzilla.Shared.Models.Cryptography
{
    public class CryptographyViewModel : ComponentBase
    {
        [Required(ErrorMessage = "Please select one type of cryptography")]
        public string DdlTypeSelected { get; set; }

        public List<DropDownListModel> DdlTypes = new List<DropDownListModel>();

        [Required(ErrorMessage = "Please enter the key")]
        public string KeyData { get; set; }

        [Required(ErrorMessage = "Please enter the input")]
        public string InputData { get; set; }

        public string OutputData { get; set; }

        [Range(1, 2, ErrorMessage = "Please choose one type of output")]
        public int OutputType { get; set; }

        public CryptographyViewModel()
        {
            DropDownListModel dropDownListModel = new DropDownListModel();
            dropDownListModel.Value = "1";
            dropDownListModel.Text = "TripleDes";
            DdlTypes.Add(dropDownListModel);

            dropDownListModel = new DropDownListModel();
            dropDownListModel.Value = "2";
            dropDownListModel.Text = "AES";
            DdlTypes.Add(dropDownListModel);

            dropDownListModel = new DropDownListModel();
            dropDownListModel.Value = "3";
            dropDownListModel.Text = "MD5";
            DdlTypes.Add(dropDownListModel);

            dropDownListModel = new DropDownListModel();
            dropDownListModel.Value = "4";
            dropDownListModel.Text = "Special Password";
            DdlTypes.Add(dropDownListModel);

            OutputType = 1;
            DdlTypeSelected = "1";

            OutputData = "";
        }
    }
}
