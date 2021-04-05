﻿using System;
using ReactiveUI;
using Splat;

namespace WinFormsLibraryManager.UI
{
    public class ConventionalViewLocator : IViewLocator
    {
        public IViewFor ResolveView<T>(T viewModel, string contract = null)
        {
            // Find view's by chopping of the 'Model' on the view model name
            // MyApp.ShellViewModel => MyApp.ShellView
            var viewModelName = viewModel.GetType().FullName;
            var viewTypeName = viewModelName.TrimEnd("Model".ToCharArray());

            try
            {
                var viewType = Type.GetType(viewTypeName);
                if (viewType != null) return Activator.CreateInstance(viewType) as IViewFor;
                this.Log().Error($"Could not find the view {viewTypeName} for view model {viewModelName}.");
                return null;
            }
            catch (Exception)
            {
                this.Log().Error($"Could not instantiate view {viewTypeName}.");
                throw;
            }
        }
    }
}