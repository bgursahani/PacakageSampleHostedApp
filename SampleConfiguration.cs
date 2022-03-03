//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************

using System;
using System.Collections.Generic;
using Microsoft.UI.Xaml.Controls;

namespace PackageSampleHostedApp
{
    public partial class MainPage : Page
    {
        public const string FEATURE_NAME = "Package";

        List<Scenario> scenarios = new List<Scenario>
        {
            new Scenario() { Title = "Identity", ClassType = typeof(PackageSampleHostedApp.Scenario1) },
            new Scenario() { Title = "Installed Location", ClassType = typeof(PackageSampleHostedApp.Scenario2) },
            new Scenario() { Title = "Dependencies", ClassType = typeof(PackageSampleHostedApp.Scenario3)},
            new Scenario() { Title = "Child Management", ClassType = typeof(PackageSampleHostedApp.Scenario4)}
        };
    }

    public class Scenario
    {
        public string Title { get; set; }
        public Type ClassType { get; set; }
    }
}
