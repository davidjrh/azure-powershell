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
    
    
    public partial class PSCloudJobSchedule
    {
        
        internal Microsoft.Azure.Batch.CloudJobSchedule omObject;
        
        private PSJobScheduleExecutionInformation executionInformation;
        
        private PSJobSpecification jobSpecification;
        
        private IList<PSMetadataItem> metadata;
        
        private PSSchedule schedule;
        
        private PSJobScheduleStatistics statistics;
        
        internal PSCloudJobSchedule(Microsoft.Azure.Batch.CloudJobSchedule omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }
        
        public System.DateTime? CreationTime
        {
            get
            {
                return this.omObject.CreationTime;
            }
        }
        
        public string DisplayName
        {
            get
            {
                return this.omObject.DisplayName;
            }
            set
            {
                this.omObject.DisplayName = value;
            }
        }
        
        public string ETag
        {
            get
            {
                return this.omObject.ETag;
            }
        }
        
        public PSJobScheduleExecutionInformation ExecutionInformation
        {
            get
            {
                if (((this.executionInformation == null) 
                            && (this.omObject.ExecutionInformation != null)))
                {
                    this.executionInformation = new PSJobScheduleExecutionInformation(this.omObject.ExecutionInformation);
                }
                return this.executionInformation;
            }
        }
        
        public string Id
        {
            get
            {
                return this.omObject.Id;
            }
            set
            {
                this.omObject.Id = value;
            }
        }
        
        public PSJobSpecification JobSpecification
        {
            get
            {
                if (((this.jobSpecification == null) 
                            && (this.omObject.JobSpecification != null)))
                {
                    this.jobSpecification = new PSJobSpecification(this.omObject.JobSpecification);
                }
                return this.jobSpecification;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.JobSpecification = null;
                }
                else
                {
                    this.omObject.JobSpecification = value.omObject;
                }
                this.jobSpecification = value;
            }
        }
        
        public System.DateTime? LastModified
        {
            get
            {
                return this.omObject.LastModified;
            }
        }
        
        public IList<PSMetadataItem> Metadata
        {
            get
            {
                if (((this.metadata == null) 
                            && (this.omObject.Metadata != null)))
                {
                    List<PSMetadataItem> list;
                    list = new List<PSMetadataItem>();
                    IEnumerator<Microsoft.Azure.Batch.MetadataItem> enumerator;
                    enumerator = this.omObject.Metadata.GetEnumerator();
                    for (
                    ; enumerator.MoveNext(); 
                    )
                    {
                        list.Add(new PSMetadataItem(enumerator.Current));
                    }
                    this.metadata = list;
                }
                return this.metadata;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.Metadata = null;
                }
                else
                {
                    this.omObject.Metadata = new List<Microsoft.Azure.Batch.MetadataItem>();
                }
                this.metadata = value;
            }
        }
        
        public Microsoft.Azure.Batch.Common.JobScheduleState? PreviousState
        {
            get
            {
                return this.omObject.PreviousState;
            }
        }
        
        public System.DateTime? PreviousStateTransitionTime
        {
            get
            {
                return this.omObject.PreviousStateTransitionTime;
            }
        }
        
        public PSSchedule Schedule
        {
            get
            {
                if (((this.schedule == null) 
                            && (this.omObject.Schedule != null)))
                {
                    this.schedule = new PSSchedule(this.omObject.Schedule);
                }
                return this.schedule;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.Schedule = null;
                }
                else
                {
                    this.omObject.Schedule = value.omObject;
                }
                this.schedule = value;
            }
        }
        
        public Microsoft.Azure.Batch.Common.JobScheduleState? State
        {
            get
            {
                return this.omObject.State;
            }
        }
        
        public System.DateTime? StateTransitionTime
        {
            get
            {
                return this.omObject.StateTransitionTime;
            }
        }
        
        public PSJobScheduleStatistics Statistics
        {
            get
            {
                if (((this.statistics == null) 
                            && (this.omObject.Statistics != null)))
                {
                    this.statistics = new PSJobScheduleStatistics(this.omObject.Statistics);
                }
                return this.statistics;
            }
        }
        
        public string Url
        {
            get
            {
                return this.omObject.Url;
            }
        }
    }
}
