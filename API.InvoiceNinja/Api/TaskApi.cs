using System;
using System.Collections.Generic;

using API.InvoiceNinja.Client;
using API.InvoiceNinja.Model;

using RestSharp;

namespace API.InvoiceNinja.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITaskApi
    {
        /// <summary>
        /// Update a task 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Object</returns>
        Object TaskTaskIdPut(Task body);
        /// <summary>
        /// List of tasks 
        /// </summary>
        /// <returns>List&lt;Task&gt;</returns>
        List<Task> TasksGet();
        /// <summary>
        /// Create a task 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Object</returns>
        Object TasksPost(Task body);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TaskApi : ITaskApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TaskApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TaskApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }

        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        /// Update a task 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Object</returns>            
        public Object TaskTaskIdPut(Task body)
        {


            var path = "/task/{task_id}";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling TaskTaskIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling TaskTaskIdPut: " + response.ErrorMessage, response.ErrorMessage);

            return (Object)ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

        /// <summary>
        /// List of tasks 
        /// </summary>
        /// <returns>List&lt;Task&gt;</returns>            
        public List<Task> TasksGet()
        {


            var path = "/tasks";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling TasksGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling TasksGet: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Task>)ApiClient.Deserialize(response.Content, typeof(List<Task>), response.Headers);
        }

        /// <summary>
        /// Create a task 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Object</returns>            
        public Object TasksPost(Task body)
        {


            var path = "/tasks";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling TasksPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling TasksPost: " + response.ErrorMessage, response.ErrorMessage);

            return (Object)ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

    }
}
