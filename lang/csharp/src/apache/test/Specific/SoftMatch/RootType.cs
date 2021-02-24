/**
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen, version 1.10.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Avro.Test.Specific.SoftMatch
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class RootType : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"RootType\",\"namespace\":\"Avro.Test.Specific.SoftMatch\",\"fields\":" +
				"[{\"name\":\"InnerComplexValue\",\"type\":[\"null\",{\"type\":\"record\",\"name\":\"InnerType2\"" +
				",\"fields\":[{\"name\":\"value\",\"type\":\"string\"}]}]}]}");
		private Avro.Test.Specific.SoftMatch.InnerType2 _InnerComplexValue;
		public virtual Schema Schema
		{
			get
			{
				return RootType._SCHEMA;
			}
		}
		public Avro.Test.Specific.SoftMatch.InnerType2 InnerComplexValue
		{
			get
			{
				return this._InnerComplexValue;
			}
			set
			{
				this._InnerComplexValue = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.InnerComplexValue;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.InnerComplexValue = (Avro.Test.Specific.SoftMatch.InnerType2)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
