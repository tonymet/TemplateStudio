// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Templates.Core;

namespace Microsoft.Templates.UI.VisualStudio
{
    public class SolutionWizardCppWinUIDesktop : SolutionWizard
    {
        public SolutionWizardCppWinUIDesktop()
        {
            Initialize(Platforms.WinUI, ProgrammingLanguages.Cpp, AppModels.Desktop);
        }
    }
}
