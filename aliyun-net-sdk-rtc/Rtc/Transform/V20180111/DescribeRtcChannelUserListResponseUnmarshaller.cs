/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.rtc.Model.V20180111;

namespace Aliyun.Acs.rtc.Transform.V20180111
{
    public class DescribeRtcChannelUserListResponseUnmarshaller
    {
        public static DescribeRtcChannelUserListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRtcChannelUserListResponse describeRtcChannelUserListResponse = new DescribeRtcChannelUserListResponse();

			describeRtcChannelUserListResponse.HttpResponse = context.HttpResponse;
			describeRtcChannelUserListResponse.RequestId = context.StringValue("DescribeRtcChannelUserList.RequestId");
			describeRtcChannelUserListResponse.PageSize = context.LongValue("DescribeRtcChannelUserList.PageSize");
			describeRtcChannelUserListResponse.PageNo = context.LongValue("DescribeRtcChannelUserList.PageNo");
			describeRtcChannelUserListResponse.TotalCnt = context.LongValue("DescribeRtcChannelUserList.TotalCnt");

			List<DescribeRtcChannelUserListResponse.DescribeRtcChannelUserList_UserListItem> describeRtcChannelUserListResponse_userList = new List<DescribeRtcChannelUserListResponse.DescribeRtcChannelUserList_UserListItem>();
			for (int i = 0; i < context.Length("DescribeRtcChannelUserList.UserList.Length"); i++) {
				DescribeRtcChannelUserListResponse.DescribeRtcChannelUserList_UserListItem userListItem = new DescribeRtcChannelUserListResponse.DescribeRtcChannelUserList_UserListItem();
				userListItem.ChannelId = context.StringValue("DescribeRtcChannelUserList.UserList["+ i +"].ChannelId");
				userListItem.UserId = context.StringValue("DescribeRtcChannelUserList.UserList["+ i +"].UserId");
				userListItem.StartTime = context.StringValue("DescribeRtcChannelUserList.UserList["+ i +"].StartTime");
				userListItem.EndTime = context.StringValue("DescribeRtcChannelUserList.UserList["+ i +"].EndTime");
				userListItem.ServiceArea = context.StringValue("DescribeRtcChannelUserList.UserList["+ i +"].ServiceArea");
				userListItem.SubAudio = context.IntegerValue("DescribeRtcChannelUserList.UserList["+ i +"].SubAudio");
				userListItem.PubAudio = context.IntegerValue("DescribeRtcChannelUserList.UserList["+ i +"].PubAudio");
				userListItem.SubVideo360 = context.IntegerValue("DescribeRtcChannelUserList.UserList["+ i +"].SubVideo360");
				userListItem.PubVideo360 = context.IntegerValue("DescribeRtcChannelUserList.UserList["+ i +"].PubVideo360");
				userListItem.SubVideo720 = context.IntegerValue("DescribeRtcChannelUserList.UserList["+ i +"].SubVideo720");
				userListItem.PubVideo720 = context.IntegerValue("DescribeRtcChannelUserList.UserList["+ i +"].PubVideo720");
				userListItem.SubVideo1080 = context.IntegerValue("DescribeRtcChannelUserList.UserList["+ i +"].SubVideo1080");
				userListItem.PubVideo1080 = context.IntegerValue("DescribeRtcChannelUserList.UserList["+ i +"].PubVideo1080");
				userListItem.SubContent = context.IntegerValue("DescribeRtcChannelUserList.UserList["+ i +"].SubContent");
				userListItem.PubContent = context.IntegerValue("DescribeRtcChannelUserList.UserList["+ i +"].PubContent");

				describeRtcChannelUserListResponse_userList.Add(userListItem);
			}
			describeRtcChannelUserListResponse.UserList = describeRtcChannelUserListResponse_userList;
        
			return describeRtcChannelUserListResponse;
        }
    }
}
