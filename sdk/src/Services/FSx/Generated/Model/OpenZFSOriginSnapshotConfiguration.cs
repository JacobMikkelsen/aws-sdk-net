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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// The snapshot configuration to use when creating an OpenZFS volume from a snapshot.
    /// </summary>
    public partial class OpenZFSOriginSnapshotConfiguration
    {
        private OpenZFSCopyStrategy _copyStrategy;
        private string _snapshotARN;

        /// <summary>
        /// Gets and sets the property CopyStrategy. 
        /// <para>
        /// The strategy used when copying data from the snapshot to the new volume. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CLONE</code> - The new volume references the data in the origin snapshot. Cloning
        /// a snapshot is faster than copying the data from a snapshot to a new volume and doesn't
        /// consume disk throughput. However, the origin snapshot can't be deleted if there is
        /// a volume using its copied data. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FULL_COPY</code> - Copies all data from the snapshot to the new volume. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public OpenZFSCopyStrategy CopyStrategy
        {
            get { return this._copyStrategy; }
            set { this._copyStrategy = value; }
        }

        // Check to see if CopyStrategy property is set
        internal bool IsSetCopyStrategy()
        {
            return this._copyStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotARN.
        /// </summary>
        [AWSProperty(Min=8, Max=512)]
        public string SnapshotARN
        {
            get { return this._snapshotARN; }
            set { this._snapshotARN = value; }
        }

        // Check to see if SnapshotARN property is set
        internal bool IsSetSnapshotARN()
        {
            return this._snapshotARN != null;
        }

    }
}