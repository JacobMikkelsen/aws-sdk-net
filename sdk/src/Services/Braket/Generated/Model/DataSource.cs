/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Braket.Model
{
    /// <summary>
    /// Information about the source of the data used by the Amazon Braket job.
    /// </summary>
    public partial class DataSource
    {
        private S3DataSource _s3DataSource;

        /// <summary>
        /// Gets and sets the property S3DataSource. 
        /// <para>
        /// Information about the data stored in Amazon S3 used by the Amazon Braket job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3DataSource S3DataSource
        {
            get { return this._s3DataSource; }
            set { this._s3DataSource = value; }
        }

        // Check to see if S3DataSource property is set
        internal bool IsSetS3DataSource()
        {
            return this._s3DataSource != null;
        }

    }
}