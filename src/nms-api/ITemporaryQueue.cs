/*
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace Apache.NMS
{
    /// <summary>
    /// Represents a temporary queue which exists for the duration 
    /// of the IConnection which created it.
    /// </summary>
    public interface ITemporaryQueue : IQueue
    {
        /// <summary>
        /// Deletes this Temporary Destination, If there are existing receivers 
        /// still using it, a NMSException will be thrown.
        /// </summary>
        /// <exception cref="Apache.NMS.NMSException">
        /// If NMS Provider fails to Delete the Temp Destination or the client does
        /// not support this operation.
        /// </exception>
        void Delete();
    }
}