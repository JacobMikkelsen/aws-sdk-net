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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Keyspaces.Model;

#pragma warning disable CS1570
namespace Amazon.Keyspaces
{
    /// <summary>
    /// <para>Interface for accessing Keyspaces</para>
    ///
    /// Amazon Keyspaces (for Apache Cassandra) is a scalable, highly available, and managed
    /// Apache Cassandra-compatible database service. Amazon Keyspaces makes it easy to migrate,
    /// run, and scale Cassandra workloads in the Amazon Web Services Cloud. With just a few
    /// clicks on the Amazon Web Services Management Console or a few lines of code, you can
    /// create keyspaces and tables in Amazon Keyspaces, without deploying any infrastructure
    /// or installing software. 
    /// 
    ///  
    /// <para>
    /// In addition to supporting Cassandra Query Language (CQL) requests via open-source
    /// Cassandra drivers, Amazon Keyspaces supports data definition language (DDL) operations
    /// to manage keyspaces and tables using the Amazon Web Services SDK and CLI, as well
    /// as infrastructure as code (IaC) services and tools such as CloudFormation and Terraform.
    /// This API reference describes the supported DDL operations in detail.
    /// </para>
    ///  
    /// <para>
    /// For the list of all supported CQL APIs, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/cassandra-apis.html">Supported
    /// Cassandra APIs, operations, and data types in Amazon Keyspaces</a> in the <i>Amazon
    /// Keyspaces Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// To learn how Amazon Keyspaces API actions are recorded with CloudTrail, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/logging-using-cloudtrail.html#service-name-info-in-cloudtrail">Amazon
    /// Keyspaces information in CloudTrail</a> in the <i>Amazon Keyspaces Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information about Amazon Web Services APIs, for example how to implement
    /// retry logic or how to sign Amazon Web Services API requests, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-apis.html">Amazon
    /// Web Services APIs</a> in the <i>General Reference</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonKeyspaces : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IKeyspacesPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateKeyspace


        /// <summary>
        /// The <c>CreateKeyspace</c> operation adds a new keyspace to your account. In an Amazon
        /// Web Services account, keyspace names must be unique within each Region.
        /// 
        ///  
        /// <para>
        ///  <c>CreateKeyspace</c> is an asynchronous operation. You can monitor the creation
        /// status of the new keyspace by using the <c>GetKeyspace</c> operation.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/getting-started.keyspaces.html">Create
        /// a keyspace</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyspace service method.</param>
        /// 
        /// <returns>The response from the CreateKeyspace service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/CreateKeyspace">REST API Reference for CreateKeyspace Operation</seealso>
        CreateKeyspaceResponse CreateKeyspace(CreateKeyspaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKeyspace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyspace operation on AmazonKeyspacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKeyspace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/CreateKeyspace">REST API Reference for CreateKeyspace Operation</seealso>
        IAsyncResult BeginCreateKeyspace(CreateKeyspaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKeyspace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKeyspace.</param>
        /// 
        /// <returns>Returns a  CreateKeyspaceResult from Keyspaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/CreateKeyspace">REST API Reference for CreateKeyspace Operation</seealso>
        CreateKeyspaceResponse EndCreateKeyspace(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTable


        /// <summary>
        /// The <c>CreateTable</c> operation adds a new table to the specified keyspace. Within
        /// a keyspace, table names must be unique.
        /// 
        ///  
        /// <para>
        ///  <c>CreateTable</c> is an asynchronous operation. When the request is received, the
        /// status of the table is set to <c>CREATING</c>. You can monitor the creation status
        /// of the new table by using the <c>GetTable</c> operation, which returns the current
        /// <c>status</c> of the table. You can start using a table when the status is <c>ACTIVE</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/getting-started.tables.html">Create
        /// a table</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTable service method.</param>
        /// 
        /// <returns>The response from the CreateTable service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/CreateTable">REST API Reference for CreateTable Operation</seealso>
        CreateTableResponse CreateTable(CreateTableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTable operation on AmazonKeyspacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/CreateTable">REST API Reference for CreateTable Operation</seealso>
        IAsyncResult BeginCreateTable(CreateTableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTable.</param>
        /// 
        /// <returns>Returns a  CreateTableResult from Keyspaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/CreateTable">REST API Reference for CreateTable Operation</seealso>
        CreateTableResponse EndCreateTable(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateType


        /// <summary>
        /// The <c>CreateType</c> operation creates a new user-defined type in the specified
        /// keyspace. 
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/udts.html">User-defined
        /// types (UDTs)</a> in the <i>Amazon Keyspaces Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateType service method.</param>
        /// 
        /// <returns>The response from the CreateType service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/CreateType">REST API Reference for CreateType Operation</seealso>
        CreateTypeResponse CreateType(CreateTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateType operation on AmazonKeyspacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/CreateType">REST API Reference for CreateType Operation</seealso>
        IAsyncResult BeginCreateType(CreateTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateType.</param>
        /// 
        /// <returns>Returns a  CreateTypeResult from Keyspaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/CreateType">REST API Reference for CreateType Operation</seealso>
        CreateTypeResponse EndCreateType(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteKeyspace


        /// <summary>
        /// The <c>DeleteKeyspace</c> operation deletes a keyspace and all of its tables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyspace service method.</param>
        /// 
        /// <returns>The response from the DeleteKeyspace service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/DeleteKeyspace">REST API Reference for DeleteKeyspace Operation</seealso>
        DeleteKeyspaceResponse DeleteKeyspace(DeleteKeyspaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKeyspace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyspace operation on AmazonKeyspacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKeyspace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/DeleteKeyspace">REST API Reference for DeleteKeyspace Operation</seealso>
        IAsyncResult BeginDeleteKeyspace(DeleteKeyspaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKeyspace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKeyspace.</param>
        /// 
        /// <returns>Returns a  DeleteKeyspaceResult from Keyspaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/DeleteKeyspace">REST API Reference for DeleteKeyspace Operation</seealso>
        DeleteKeyspaceResponse EndDeleteKeyspace(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTable


        /// <summary>
        /// The <c>DeleteTable</c> operation deletes a table and all of its data. After a <c>DeleteTable</c>
        /// request is received, the specified table is in the <c>DELETING</c> state until Amazon
        /// Keyspaces completes the deletion. If the table is in the <c>ACTIVE</c> state, you
        /// can delete it. If a table is either in the <c>CREATING</c> or <c>UPDATING</c> states,
        /// then Amazon Keyspaces returns a <c>ResourceInUseException</c>. If the specified table
        /// does not exist, Amazon Keyspaces returns a <c>ResourceNotFoundException</c>. If the
        /// table is already in the <c>DELETING</c> state, no error is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTable service method.</param>
        /// 
        /// <returns>The response from the DeleteTable service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        DeleteTableResponse DeleteTable(DeleteTableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTable operation on AmazonKeyspacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        IAsyncResult BeginDeleteTable(DeleteTableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTable.</param>
        /// 
        /// <returns>Returns a  DeleteTableResult from Keyspaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        DeleteTableResponse EndDeleteTable(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteType


        /// <summary>
        /// The <c>DeleteType</c> operation deletes a user-defined type (UDT). You can only delete
        /// a type that is not used in a table or another UDT.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteType service method.</param>
        /// 
        /// <returns>The response from the DeleteType service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/DeleteType">REST API Reference for DeleteType Operation</seealso>
        DeleteTypeResponse DeleteType(DeleteTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteType operation on AmazonKeyspacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/DeleteType">REST API Reference for DeleteType Operation</seealso>
        IAsyncResult BeginDeleteType(DeleteTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteType.</param>
        /// 
        /// <returns>Returns a  DeleteTypeResult from Keyspaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/DeleteType">REST API Reference for DeleteType Operation</seealso>
        DeleteTypeResponse EndDeleteType(IAsyncResult asyncResult);

        #endregion
        
        #region  GetKeyspace


        /// <summary>
        /// Returns the name and the Amazon Resource Name (ARN) of the specified table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyspace service method.</param>
        /// 
        /// <returns>The response from the GetKeyspace service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/GetKeyspace">REST API Reference for GetKeyspace Operation</seealso>
        GetKeyspaceResponse GetKeyspace(GetKeyspaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetKeyspace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKeyspace operation on AmazonKeyspacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKeyspace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/GetKeyspace">REST API Reference for GetKeyspace Operation</seealso>
        IAsyncResult BeginGetKeyspace(GetKeyspaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetKeyspace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKeyspace.</param>
        /// 
        /// <returns>Returns a  GetKeyspaceResult from Keyspaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/GetKeyspace">REST API Reference for GetKeyspace Operation</seealso>
        GetKeyspaceResponse EndGetKeyspace(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTable


        /// <summary>
        /// Returns information about the table, including the table's name and current status,
        /// the keyspace name, configuration settings, and metadata.
        /// 
        ///  
        /// <para>
        /// To read table metadata using <c>GetTable</c>, the IAM principal needs <c>Select</c>
        /// action permissions for the table and the system keyspace.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTable service method.</param>
        /// 
        /// <returns>The response from the GetTable service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/GetTable">REST API Reference for GetTable Operation</seealso>
        GetTableResponse GetTable(GetTableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTable operation on AmazonKeyspacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/GetTable">REST API Reference for GetTable Operation</seealso>
        IAsyncResult BeginGetTable(GetTableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTable.</param>
        /// 
        /// <returns>Returns a  GetTableResult from Keyspaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/GetTable">REST API Reference for GetTable Operation</seealso>
        GetTableResponse EndGetTable(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTableAutoScalingSettings


        /// <summary>
        /// Returns auto scaling related settings of the specified table in JSON format. If the
        /// table is a multi-Region table, the Amazon Web Services Region specific auto scaling
        /// settings of the table are included.
        /// 
        ///  
        /// <para>
        /// Amazon Keyspaces auto scaling helps you provision throughput capacity for variable
        /// workloads efficiently by increasing and decreasing your table's read and write capacity
        /// automatically in response to application traffic. For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/autoscaling.html">Managing
        /// throughput capacity automatically with Amazon Keyspaces auto scaling</a> in the <i>Amazon
        /// Keyspaces Developer Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        ///  <c>GetTableAutoScalingSettings</c> can't be used as an action in an IAM policy.
        /// </para>
        ///  </important> 
        /// <para>
        /// To define permissions for <c>GetTableAutoScalingSettings</c>, you must allow the following
        /// two actions in the IAM policy statement's <c>Action</c> element:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>application-autoscaling:DescribeScalableTargets</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application-autoscaling:DescribeScalingPolicies</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableAutoScalingSettings service method.</param>
        /// 
        /// <returns>The response from the GetTableAutoScalingSettings service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/GetTableAutoScalingSettings">REST API Reference for GetTableAutoScalingSettings Operation</seealso>
        GetTableAutoScalingSettingsResponse GetTableAutoScalingSettings(GetTableAutoScalingSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTableAutoScalingSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableAutoScalingSettings operation on AmazonKeyspacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTableAutoScalingSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/GetTableAutoScalingSettings">REST API Reference for GetTableAutoScalingSettings Operation</seealso>
        IAsyncResult BeginGetTableAutoScalingSettings(GetTableAutoScalingSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTableAutoScalingSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTableAutoScalingSettings.</param>
        /// 
        /// <returns>Returns a  GetTableAutoScalingSettingsResult from Keyspaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/GetTableAutoScalingSettings">REST API Reference for GetTableAutoScalingSettings Operation</seealso>
        GetTableAutoScalingSettingsResponse EndGetTableAutoScalingSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  GetType


        /// <summary>
        /// The <c>GetType</c> operation returns information about the type, for example the
        /// field definitions, the timestamp when the type was last modified, the level of nesting,
        /// the status, and details about if the type is used in other types and tables. 
        /// 
        ///  
        /// <para>
        /// To read keyspace metadata using <c>GetType</c>, the IAM principal needs <c>Select</c>
        /// action permissions for the system keyspace.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetType service method.</param>
        /// 
        /// <returns>The response from the GetType service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/GetType">REST API Reference for GetType Operation</seealso>
        GetTypeResponse GetType(GetTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetType operation on AmazonKeyspacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/GetType">REST API Reference for GetType Operation</seealso>
        IAsyncResult BeginGetType(GetTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetType.</param>
        /// 
        /// <returns>Returns a  GetTypeResult from Keyspaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/GetType">REST API Reference for GetType Operation</seealso>
        GetTypeResponse EndGetType(IAsyncResult asyncResult);

        #endregion
        
        #region  ListKeyspaces


        /// <summary>
        /// The <c>ListKeyspaces</c> operation returns a list of keyspaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeyspaces service method.</param>
        /// 
        /// <returns>The response from the ListKeyspaces service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/ListKeyspaces">REST API Reference for ListKeyspaces Operation</seealso>
        ListKeyspacesResponse ListKeyspaces(ListKeyspacesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListKeyspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKeyspaces operation on AmazonKeyspacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKeyspaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/ListKeyspaces">REST API Reference for ListKeyspaces Operation</seealso>
        IAsyncResult BeginListKeyspaces(ListKeyspacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListKeyspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKeyspaces.</param>
        /// 
        /// <returns>Returns a  ListKeyspacesResult from Keyspaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/ListKeyspaces">REST API Reference for ListKeyspaces Operation</seealso>
        ListKeyspacesResponse EndListKeyspaces(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTables


        /// <summary>
        /// The <c>ListTables</c> operation returns a list of tables for a specified keyspace.
        /// 
        ///  
        /// <para>
        /// To read keyspace metadata using <c>ListTables</c>, the IAM principal needs <c>Select</c>
        /// action permissions for the system keyspace.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTables service method.</param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/ListTables">REST API Reference for ListTables Operation</seealso>
        ListTablesResponse ListTables(ListTablesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTables operation on AmazonKeyspacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTables
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/ListTables">REST API Reference for ListTables Operation</seealso>
        IAsyncResult BeginListTables(ListTablesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTables operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTables.</param>
        /// 
        /// <returns>Returns a  ListTablesResult from Keyspaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/ListTables">REST API Reference for ListTables Operation</seealso>
        ListTablesResponse EndListTables(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of all tags associated with the specified Amazon Keyspaces resource.
        /// 
        ///  
        /// <para>
        /// To read keyspace metadata using <c>ListTagsForResource</c>, the IAM principal needs
        /// <c>Select</c> action permissions for the specified resource and the system keyspace.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonKeyspacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Keyspaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTypes


        /// <summary>
        /// The <c>ListTypes</c> operation returns a list of types for a specified keyspace.
        /// 
        /// 
        ///  
        /// <para>
        /// To read keyspace metadata using <c>ListTypes</c>, the IAM principal needs <c>Select</c>
        /// action permissions for the system keyspace.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTypes service method.</param>
        /// 
        /// <returns>The response from the ListTypes service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/ListTypes">REST API Reference for ListTypes Operation</seealso>
        ListTypesResponse ListTypes(ListTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTypes operation on AmazonKeyspacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/ListTypes">REST API Reference for ListTypes Operation</seealso>
        IAsyncResult BeginListTypes(ListTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTypes.</param>
        /// 
        /// <returns>Returns a  ListTypesResult from Keyspaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/ListTypes">REST API Reference for ListTypes Operation</seealso>
        ListTypesResponse EndListTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  RestoreTable


        /// <summary>
        /// Restores the table to the specified point in time within the <c>earliest_restorable_timestamp</c>
        /// and the current time. For more information about restore points, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/PointInTimeRecovery_HowItWorks.html#howitworks_backup_window">
        /// Time window for PITR continuous backups</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// Any number of users can execute up to 4 concurrent restores (any type of restore)
        /// in a given account.
        /// </para>
        ///  
        /// <para>
        /// When you restore using point in time recovery, Amazon Keyspaces restores your source
        /// table's schema and data to the state based on the selected timestamp <c>(day:hour:minute:second)</c>
        /// to a new table. The Time to Live (TTL) settings are also restored to the state based
        /// on the selected timestamp.
        /// </para>
        ///  
        /// <para>
        /// In addition to the table's schema, data, and TTL settings, <c>RestoreTable</c> restores
        /// the capacity mode, auto scaling settings, encryption settings, and point-in-time recovery
        /// settings from the source table. Unlike the table's schema data and TTL settings, which
        /// are restored based on the selected timestamp, these settings are always restored based
        /// on the table's settings as of the current time or when the table was deleted.
        /// </para>
        ///  
        /// <para>
        /// You can also overwrite these settings during restore:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Read/write capacity mode
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provisioned throughput capacity units
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Auto scaling settings
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Point-in-time (PITR) settings
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/PointInTimeRecovery_HowItWorks.html#howitworks_backup_settings">PITR
        /// restore settings</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Note that the following settings are not restored, and you must configure them manually
        /// for the new table:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Identity and Access Management (IAM) policies
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon CloudWatch metrics and alarms
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreTable service method.</param>
        /// 
        /// <returns>The response from the RestoreTable service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/RestoreTable">REST API Reference for RestoreTable Operation</seealso>
        RestoreTableResponse RestoreTable(RestoreTableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreTable operation on AmazonKeyspacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/RestoreTable">REST API Reference for RestoreTable Operation</seealso>
        IAsyncResult BeginRestoreTable(RestoreTableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreTable.</param>
        /// 
        /// <returns>Returns a  RestoreTableResult from Keyspaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/RestoreTable">REST API Reference for RestoreTable Operation</seealso>
        RestoreTableResponse EndRestoreTable(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associates a set of tags with a Amazon Keyspaces resource. You can then activate these
        /// user-defined tags so that they appear on the Cost Management Console for cost allocation
        /// tracking. For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/tagging-keyspaces.html">Adding
        /// tags and labels to Amazon Keyspaces resources</a> in the <i>Amazon Keyspaces Developer
        /// Guide</i>.
        /// 
        ///  
        /// <para>
        /// For IAM policy examples that show how to control access to Amazon Keyspaces resources
        /// based on tags, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/security_iam_id-based-policy-examples.html#security_iam_id-based-policy-examples-tags">Amazon
        /// Keyspaces resource access based on tags</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonKeyspacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Keyspaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the association of tags from a Amazon Keyspaces resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonKeyspacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Keyspaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTable


        /// <summary>
        /// Adds new columns to the table or updates one of the table's settings, for example
        /// capacity mode, auto scaling, encryption, point-in-time recovery, or ttl settings.
        /// Note that you can only update one specific table setting per update operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTable service method.</param>
        /// 
        /// <returns>The response from the UpdateTable service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/UpdateTable">REST API Reference for UpdateTable Operation</seealso>
        UpdateTableResponse UpdateTable(UpdateTableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTable operation on AmazonKeyspacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/UpdateTable">REST API Reference for UpdateTable Operation</seealso>
        IAsyncResult BeginUpdateTable(UpdateTableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTable.</param>
        /// 
        /// <returns>Returns a  UpdateTableResult from Keyspaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/UpdateTable">REST API Reference for UpdateTable Operation</seealso>
        UpdateTableResponse EndUpdateTable(IAsyncResult asyncResult);

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}