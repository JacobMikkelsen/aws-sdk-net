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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Container for the parameters to the ListTagsForResource operation.
    /// Lists all tags associated with a given transcription job, vocabulary, or resource.
    /// </summary>
    public partial class ListTagsForResourceRequest : AmazonTranscribeServiceRequest
    {
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// Lists all tags associated with a given Amazon Resource Name (ARN). ARNs have the format
        /// <code>arn:partition:service:region:account-id:resource-type/resource-id</code> (for
        /// example, <code>arn:aws:transcribe:us-east-1:account-id:transcription-job/your-job-name</code>).
        /// Valid values for <code>resource-type</code> are: <code>transcription-job</code>, <code>medical-transcription-job</code>,
        /// <code>vocabulary</code>, <code>medical-vocabulary</code>, <code>vocabulary-filter</code>,
        /// and <code>language-model</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}