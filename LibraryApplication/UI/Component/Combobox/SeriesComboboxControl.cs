﻿using System.Collections.ObjectModel;
using LibraryApplication.Model.Meta;

namespace LibraryApplication.UI.Component.Combobox
{
    public class SeriesComboboxControl : BaseComboboxControl<Series>
    {
        protected sealed override ObservableCollection<Series> LocalContext => Context.Series.Local;

        public SeriesComboboxControl()
        {
            Hint = "Select Series";
            Label = "Series";
        }
    }
}