/*
 * Copyright 2019 Samsung Electronics Co., Ltd. All rights reserved.
 *
 * Licensed under the Flora License, Version 1.1 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://floralicense.org/license
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace TextReader.Views
{
    /// <summary>
    /// Provides methods which allow to navigate between pages.
    /// </summary>
    public interface IPageNavigation
    {
        #region methods

        /// <summary>
        /// Navigates to the 'how-to' page.
        /// </summary>
        void NavigateToHowToPage();

        /// <summary>
        /// Navigates to the text reader page.
        /// </summary>
        void NavigateToTextReader();

        /// <summary>
        /// Navigates to the welcome page.
        /// </summary>
        void NavigateToWelcomePage();

        #endregion
    }
}
