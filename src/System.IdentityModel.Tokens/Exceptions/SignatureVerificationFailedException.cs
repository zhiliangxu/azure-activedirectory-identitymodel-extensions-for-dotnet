//-----------------------------------------------------------------------
// Copyright (c) Microsoft Open Technologies, Inc.
// All Rights Reserved
// Apache License 2.0
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//-----------------------------------------------------------------------

using System.IdentityModel.Tokens;

namespace System.IdentityModel
{    
    /// <summary>
    /// This indicates an error has occured while processing a signature
    /// </summary>
    public class SignatureVerificationFailedException : SecurityTokenException
    {
        /// <summary>
        /// Initializes a new instance of  <see cref="SignatureVerificationFailedException"/>
        /// </summary>
        public SignatureVerificationFailedException()
            : base("Signature Failed")
            // TODO - brentsch Error message.
        {
        }

        /// <summary>
        /// Initializes a new instance of  <see cref="SignatureVerificationFailedException"/>
        /// </summary>
        public SignatureVerificationFailedException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of  <see cref="SignatureVerificationFailedException"/>
        /// </summary>
        public SignatureVerificationFailedException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
