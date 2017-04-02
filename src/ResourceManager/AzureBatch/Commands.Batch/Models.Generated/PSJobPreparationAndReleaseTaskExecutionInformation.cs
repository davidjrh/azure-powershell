﻿// -----------------------------------------------------------------------------
﻿//
﻿// Copyright Microsoft Corporation
﻿// Licensed under the Apache License, Version 2.0 (the "License");
﻿// you may not use this file except in compliance with the License.
﻿// You may obtain a copy of the License at
﻿// http://www.apache.org/licenses/LICENSE-2.0
﻿// Unless required by applicable law or agreed to in writing, software
﻿// distributed under the License is distributed on an "AS IS" BASIS,
﻿// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
﻿// See the License for the specific language governing permissions and
﻿// limitations under the License.
﻿// -----------------------------------------------------------------------------
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Batch.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Microsoft.Azure.Batch;
    
    
    public partial class PSJobPreparationAndReleaseTaskExecutionInformation
    {
        
        internal Microsoft.Azure.Batch.JobPreparationAndReleaseTaskExecutionInformation omObject;
        
        private PSJobPreparationTaskExecutionInformation jobPreparationTaskExecutionInformation;
        
        private PSJobReleaseTaskExecutionInformation jobReleaseTaskExecutionInformation;
        
        internal PSJobPreparationAndReleaseTaskExecutionInformation(Microsoft.Azure.Batch.JobPreparationAndReleaseTaskExecutionInformation omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }
        
        public string ComputeNodeId
        {
            get
            {
                return this.omObject.ComputeNodeId;
            }
        }
        
        public string ComputeNodeUrl
        {
            get
            {
                return this.omObject.ComputeNodeUrl;
            }
        }
        
        public PSJobPreparationTaskExecutionInformation JobPreparationTaskExecutionInformation
        {
            get
            {
                if (((this.jobPreparationTaskExecutionInformation == null) 
                            && (this.omObject.JobPreparationTaskExecutionInformation != null)))
                {
                    this.jobPreparationTaskExecutionInformation = new PSJobPreparationTaskExecutionInformation(this.omObject.JobPreparationTaskExecutionInformation);
                }
                return this.jobPreparationTaskExecutionInformation;
            }
        }
        
        public PSJobReleaseTaskExecutionInformation JobReleaseTaskExecutionInformation
        {
            get
            {
                if (((this.jobReleaseTaskExecutionInformation == null) 
                            && (this.omObject.JobReleaseTaskExecutionInformation != null)))
                {
                    this.jobReleaseTaskExecutionInformation = new PSJobReleaseTaskExecutionInformation(this.omObject.JobReleaseTaskExecutionInformation);
                }
                return this.jobReleaseTaskExecutionInformation;
            }
        }
        
        public string PoolId
        {
            get
            {
                return this.omObject.PoolId;
            }
        }
    }
}
