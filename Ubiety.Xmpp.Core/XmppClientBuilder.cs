﻿// Copyright 2018 Dieter Lunn
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.

namespace Ubiety.Xmpp.Core
{
    /// <summary>
    ///     Builds a new XmppClient
    /// </summary>
    public class XmppClientBuilder
    {
        private XmppClient _client;

        /// <summary>
        ///     Begin the build process
        /// </summary>
        /// <returns>Builder instance</returns>
        public XmppClientBuilder Begin()
        {
            _client = new XmppClient();
            return this;
        }

        /// <summary>
        ///     Builds the client
        /// </summary>
        /// <returns>Client with the options provided</returns>
        public XmppClient Build()
        {
            return _client;
        }
    }
}