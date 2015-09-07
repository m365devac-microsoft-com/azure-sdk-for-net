﻿// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.DataFactories.Common.Models;
using Microsoft.Azure.Management.DataFactories.Models;

namespace Microsoft.Azure.Management.DataFactories
{
    public static partial class OAuthOperationsExtensions
    {
        /// <summary>
        /// Gets an OAuth authorization session.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IOAuthOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='linkedServiceType'>
        /// Required. The type of OAuth linked service.
        /// </param>
        /// <returns>
        /// The Get authorization session operation response.
        /// </returns>
        public static AuthorizationSessionGetResponse Get(this IOAuthOperations operations, string resourceGroupName, string dataFactoryName, string linkedServiceType)
        {
            return Task.Factory.StartNew((object s) =>
            {
                return ((IOAuthOperations)s).GetAsync(resourceGroupName, dataFactoryName, linkedServiceType);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets an OAuth authorization session.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IOAuthOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='linkedServiceType'>
        /// Required. The type of OAuth linked service.
        /// </param>
        /// <returns>
        /// The Get authorization session operation response.
        /// </returns>
        public static Task<AuthorizationSessionGetResponse> GetAsync(this IOAuthOperations operations, string resourceGroupName, string dataFactoryName, string linkedServiceType)
        {
            return operations.GetAsync(resourceGroupName, dataFactoryName, linkedServiceType, CancellationToken.None);
        }
    }
}
