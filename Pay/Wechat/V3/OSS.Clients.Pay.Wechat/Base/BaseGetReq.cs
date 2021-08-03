﻿#region Copyright (C) 2021 Kevin (OSS开源实验室) 公众号：osscore

/***************************************************************************
*　　	文件功能描述：微信支付模快 —— 请求基类
*
*　　	创建人： Kevin
*       创建人Email：1985088337@qq.com
*    	创建日期：2021-7-21
*       
*****************************************************************************/

#endregion


using System.Collections.Generic;
using System.Net.Http;

namespace OSS.Clients.Pay.Wechat
{
    /// <summary>
    ///  请求基类
    /// </summary>
    public abstract class BaseGetReq<TReq, TResp>: InternalBaseReq<TReq, TResp>
        where TReq : BaseGetReq<TReq, TResp>
        where TResp : BaseResp
    {
        public BaseGetReq() : base(HttpMethod.Get)
        {
        }

        /// <summary>
        ///  准备对应的query参数
        /// </summary>
        /// <returns>如: ?mch_id=xxx</returns>
        protected abstract string PrepareQueryString();

        // query参数串
        internal override string GetQueryString()
        {
            return PrepareQueryString();
        }

        // body 普通字段字典
        internal override Dictionary<string, object> GetSendParaDics()
        {
            return null;
        }

        // body 敏感字段字段
        internal override Dictionary<string, string> GetSendEncryptParaDics()
        {
            return null;
        }
    }
}
