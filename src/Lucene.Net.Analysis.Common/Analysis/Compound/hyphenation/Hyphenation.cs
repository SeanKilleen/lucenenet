﻿/*
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 * 
 *      http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace org.apache.lucene.analysis.compound.hyphenation
{

	/// <summary>
	/// This class represents a hyphenated word.
	/// 
	/// This class has been taken from the Apache FOP project (http://xmlgraphics.apache.org/fop/). They have been slightly modified.
	/// </summary>
	public class Hyphenation
	{

	  private int[] hyphenPoints;

	  /// <summary>
	  /// rawWord as made of alternating strings and <seealso cref="Hyphen Hyphen"/> instances
	  /// </summary>
	  internal Hyphenation(int[] points)
	  {
		hyphenPoints = points;
	  }

	  /// <returns> the number of hyphenation points in the word </returns>
	  public virtual int length()
	  {
		return hyphenPoints.Length;
	  }

	  /// <returns> the hyphenation points </returns>
	  public virtual int[] HyphenationPoints
	  {
		  get
		  {
			return hyphenPoints;
		  }
	  }
	}

}