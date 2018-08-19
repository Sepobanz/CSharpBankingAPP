//========================================================================
// This conversion was produced by the Free Edition of
// Java to C# Converter courtesy of Tangible Software Solutions.
// Order the Premium Edition at https://www.tangiblesoftwaresolutions.com
//========================================================================

using System.Collections.Generic;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
namespace bankingapp
{

	/// 
	/// <summary>
	/// @author Patsf
	/// </summary>
	public interface DAO<T>
	{
		T get(string code);
		IList<T> All {get;}
		bool add(T t);
		bool update(T t);
		bool delete(T t);

	}

}