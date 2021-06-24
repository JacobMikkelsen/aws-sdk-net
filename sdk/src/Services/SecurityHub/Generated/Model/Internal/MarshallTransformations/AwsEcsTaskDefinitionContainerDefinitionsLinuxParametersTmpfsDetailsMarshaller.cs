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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersTmpfsDetails Marshaller
    /// </summary>       
    public class AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersTmpfsDetailsMarshaller : IRequestMarshaller<AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersTmpfsDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersTmpfsDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetContainerPath())
            {
                context.Writer.WritePropertyName("ContainerPath");
                context.Writer.Write(requestObject.ContainerPath);
            }

            if(requestObject.IsSetMountOptions())
            {
                context.Writer.WritePropertyName("MountOptions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMountOptionsListValue in requestObject.MountOptions)
                {
                        context.Writer.Write(requestObjectMountOptionsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSize())
            {
                context.Writer.WritePropertyName("Size");
                context.Writer.Write(requestObject.Size);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersTmpfsDetailsMarshaller Instance = new AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersTmpfsDetailsMarshaller();

    }
}