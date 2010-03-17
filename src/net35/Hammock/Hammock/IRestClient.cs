﻿using System;

namespace Hammock
{
    public interface IRestClient
    {
#if !Silverlight
        RestResponse Request(RestRequest request);
        RestResponse<T> Request<T>(RestRequest request);
#endif
        IAsyncResult BeginRequest(RestRequest request, RestCallback callback);
        IAsyncResult BeginRequest<T>(RestRequest request, RestCallback<T> callback);
    }
}