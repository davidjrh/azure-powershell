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
    
    
    public partial class PSCertificate
    {
        
        internal Microsoft.Azure.Batch.Certificate omObject;
        
        private PSDeleteCertificateError deleteCertificateError;
        
        internal PSCertificate(Microsoft.Azure.Batch.Certificate omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }
        
        public Microsoft.Azure.Batch.Common.CertificateFormat? CertificateFormat
        {
            get
            {
                return this.omObject.CertificateFormat;
            }
        }
        
        public string Data
        {
            get
            {
                return this.omObject.Data;
            }
        }
        
        public PSDeleteCertificateError DeleteCertificateError
        {
            get
            {
                if (((this.deleteCertificateError == null) 
                            && (this.omObject.DeleteCertificateError != null)))
                {
                    this.deleteCertificateError = new PSDeleteCertificateError(this.omObject.DeleteCertificateError);
                }
                return this.deleteCertificateError;
            }
        }
        
        public string Password
        {
            get
            {
                return this.omObject.Password;
            }
        }
        
        public Microsoft.Azure.Batch.Common.CertificateState? PreviousState
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
        
        public string PublicData
        {
            get
            {
                return this.omObject.PublicData;
            }
        }
        
        public Microsoft.Azure.Batch.Common.CertificateState? State
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
        
        public string Thumbprint
        {
            get
            {
                return this.omObject.Thumbprint;
            }
        }
        
        public string ThumbprintAlgorithm
        {
            get
            {
                return this.omObject.ThumbprintAlgorithm;
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
