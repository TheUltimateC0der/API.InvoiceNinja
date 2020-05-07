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
    public interface IProductApi
    {
        /// <summary>
        /// List of products 
        /// </summary>
        /// <returns>List&lt;Product&gt;</returns>
        List<Product> ProductsGet();
        /// <summary>
        /// Create a product 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Object</returns>
        Object ProductsPost(Product body);
        /// <summary>
        /// Update a product 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Object</returns>
        Object ProductsProductIdPut(Product body);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ProductApi : IProductApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ProductApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductApi(String basePath)
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
        /// List of products 
        /// </summary>
        /// <returns>List&lt;Product&gt;</returns>            
        public List<Product> ProductsGet()
        {


            var path = "/products";
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
                throw new ApiException((int)response.StatusCode, "Error calling ProductsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ProductsGet: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Product>)ApiClient.Deserialize(response.Content, typeof(List<Product>), response.Headers);
        }

        /// <summary>
        /// Create a product 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Object</returns>            
        public Object ProductsPost(Product body)
        {


            var path = "/products";
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
                throw new ApiException((int)response.StatusCode, "Error calling ProductsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ProductsPost: " + response.ErrorMessage, response.ErrorMessage);

            return (Object)ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

        /// <summary>
        /// Update a product 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Object</returns>            
        public Object ProductsProductIdPut(Product body)
        {


            var path = "/products/{product_id}";
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
                throw new ApiException((int)response.StatusCode, "Error calling ProductsProductIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ProductsProductIdPut: " + response.ErrorMessage, response.ErrorMessage);

            return (Object)ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

    }
}
