﻿using System;

namespace D2L.WS.Client.Proxy {
	public interface IGradesManagementServicev1_2 : IHeaderService {
		IAsyncResult BeginCreateSelectBoxGradeItem( CreateSelectBoxGradeItemRequest CreateSelectBoxGradeItemRequest, AsyncCallback callback, object asyncState );
		IAsyncResult BeginGetAdjustedFinalGrade( GetAdjustedFinalGradeRequest GetAdjustedFinalGradeRequest, AsyncCallback callback, object asyncState );
		IAsyncResult BeginGetFinalGradeSymbolsByUser( GetFinalGradeSymbolsByUserRequest GetFinalGradeSymbolsByUserRequest, AsyncCallback callback, object asyncState );
		IAsyncResult BeginGetGradeSchemeByGradeObject( GetGradeSchemeByGradeObjectRequest GetGradeSchemeByGradeObjectRequest, AsyncCallback callback, object asyncState );
		IAsyncResult BeginGetGradeSchemesByOrgUnit( GetGradeSchemesByOrgUnitRequest GetGradeSchemesByOrgUnitRequest, AsyncCallback callback, object asyncState );
		IAsyncResult BeginGetGradeSymbolsByGradeObject( GetGradeSymbolsByGradeObjectRequest GetGradeSymbolsByGradeObjectRequest, AsyncCallback callback, object asyncState );
		IAsyncResult BeginGetGradeSymbolsByUserOrgUnit( GetGradeSymbolsByUserOrgUnitRequest GetGradeSymbolsByUserOrgUnitRequest, AsyncCallback callback, object asyncState );
		IAsyncResult BeginGetGradeValuesByUserGradeObject( GetGradeValuesByUserGradeObjectRequest GetGradeValuesByUserGradeObjectRequest, AsyncCallback callback, object asyncState );
		IAsyncResult BeginGetGradeValuesWithUserInfoByGradeObject( GetGradeValuesWithUserInfoByGradeObjectRequest GetGradeValuesWithUserInfoByGradeObjectRequest, AsyncCallback callback, object asyncState );
		IAsyncResult BeginGetSelectBoxGradeItem( GetSelectBoxGradeItemRequest GetSelectBoxGradeItemRequest, AsyncCallback callback, object asyncState );
		IAsyncResult BeginGetStatisticsByGradeObject( GetStatisticsByGradeObjectRequest GetStatisticsByGradeObjectRequest, AsyncCallback callback, object asyncState );
		IAsyncResult BeginSetSelectBoxGradeValue( SetSelectBoxGradeValueRequest SetSelectBoxGradeValueRequest, AsyncCallback callback, object asyncState );
		IAsyncResult BeginUpdateNumericGradeItem( UpdateNumericGradeItemRequest UpdateNumericGradeItemRequest, AsyncCallback callback, object asyncState );
		IAsyncResult BeginUpdatePassFailGradeItem( UpdatePassFailGradeItemRequest UpdatePassFailGradeItemRequest, AsyncCallback callback, object asyncState );
		IAsyncResult BeginUpdateSelectBoxGradeItem( UpdateSelectBoxGradeItemRequest UpdateSelectBoxGradeItemRequest, AsyncCallback callback, object asyncState );
		IAsyncResult BeginUpdateTextGradeItem( UpdateTextGradeItemRequest UpdateTextGradeItemRequest, AsyncCallback callback, object asyncState );
		void CancelAsync( object userState );
		CreateSelectBoxGradeItemResponse CreateSelectBoxGradeItem( CreateSelectBoxGradeItemRequest CreateSelectBoxGradeItemRequest );
		void CreateSelectBoxGradeItemAsync( CreateSelectBoxGradeItemRequest CreateSelectBoxGradeItemRequest, object userState );
		void CreateSelectBoxGradeItemAsync( CreateSelectBoxGradeItemRequest CreateSelectBoxGradeItemRequest );
		event CreateSelectBoxGradeItemCompletedEventHandler CreateSelectBoxGradeItemCompleted;
		CreateSelectBoxGradeItemResponse EndCreateSelectBoxGradeItem( IAsyncResult asyncResult );
		GetAdjustedFinalGradeResponse EndGetAdjustedFinalGrade( IAsyncResult asyncResult );
		GetFinalGradeSymbolsByUserResponse EndGetFinalGradeSymbolsByUser( IAsyncResult asyncResult );
		GetGradeSchemeByGradeObjectResponse EndGetGradeSchemeByGradeObject( IAsyncResult asyncResult );
		GetGradeSchemesByOrgUnitResponse EndGetGradeSchemesByOrgUnit( IAsyncResult asyncResult );
		GetGradeSymbolsByGradeObjectResponse EndGetGradeSymbolsByGradeObject( IAsyncResult asyncResult );
		GetGradeSymbolsByUserOrgUnitResponse EndGetGradeSymbolsByUserOrgUnit( IAsyncResult asyncResult );
		GetGradeValuesByUserGradeObjectResponse EndGetGradeValuesByUserGradeObject( IAsyncResult asyncResult );
		GetGradeValuesWithUserInfoByGradeObjectResponse EndGetGradeValuesWithUserInfoByGradeObject( IAsyncResult asyncResult );
		GetSelectBoxGradeItemResponse EndGetSelectBoxGradeItem( IAsyncResult asyncResult );
		GetStatisticsByGradeObjectResponse EndGetStatisticsByGradeObject( IAsyncResult asyncResult );
		SetGradeValueResponse EndSetSelectBoxGradeValue( IAsyncResult asyncResult );
		UpdateGradeItemResponse EndUpdateNumericGradeItem( IAsyncResult asyncResult );
		UpdateGradeItemResponse EndUpdatePassFailGradeItem( IAsyncResult asyncResult );
		UpdateGradeItemResponse EndUpdateSelectBoxGradeItem( IAsyncResult asyncResult );
		UpdateGradeItemResponse EndUpdateTextGradeItem( IAsyncResult asyncResult );
		GetAdjustedFinalGradeResponse GetAdjustedFinalGrade( GetAdjustedFinalGradeRequest GetAdjustedFinalGradeRequest );
		void GetAdjustedFinalGradeAsync( GetAdjustedFinalGradeRequest GetAdjustedFinalGradeRequest );
		void GetAdjustedFinalGradeAsync( GetAdjustedFinalGradeRequest GetAdjustedFinalGradeRequest, object userState );
		event GetAdjustedFinalGradeCompletedEventHandler GetAdjustedFinalGradeCompleted;
		GetFinalGradeSymbolsByUserResponse GetFinalGradeSymbolsByUser( GetFinalGradeSymbolsByUserRequest GetFinalGradeSymbolsByUserRequest );
		void GetFinalGradeSymbolsByUserAsync( GetFinalGradeSymbolsByUserRequest GetFinalGradeSymbolsByUserRequest );
		void GetFinalGradeSymbolsByUserAsync( GetFinalGradeSymbolsByUserRequest GetFinalGradeSymbolsByUserRequest, object userState );
		event GetFinalGradeSymbolsByUserCompletedEventHandler GetFinalGradeSymbolsByUserCompleted;
		GetGradeSchemeByGradeObjectResponse GetGradeSchemeByGradeObject( GetGradeSchemeByGradeObjectRequest GetGradeSchemeByGradeObjectRequest );
		void GetGradeSchemeByGradeObjectAsync( GetGradeSchemeByGradeObjectRequest GetGradeSchemeByGradeObjectRequest );
		void GetGradeSchemeByGradeObjectAsync( GetGradeSchemeByGradeObjectRequest GetGradeSchemeByGradeObjectRequest, object userState );
		event GetGradeSchemeByGradeObjectCompletedEventHandler GetGradeSchemeByGradeObjectCompleted;
		GetGradeSchemesByOrgUnitResponse GetGradeSchemesByOrgUnit( GetGradeSchemesByOrgUnitRequest GetGradeSchemesByOrgUnitRequest );
		void GetGradeSchemesByOrgUnitAsync( GetGradeSchemesByOrgUnitRequest GetGradeSchemesByOrgUnitRequest, object userState );
		void GetGradeSchemesByOrgUnitAsync( GetGradeSchemesByOrgUnitRequest GetGradeSchemesByOrgUnitRequest );
		event GetGradeSchemesByOrgUnitCompletedEventHandler GetGradeSchemesByOrgUnitCompleted;
		GetGradeSymbolsByGradeObjectResponse GetGradeSymbolsByGradeObject( GetGradeSymbolsByGradeObjectRequest GetGradeSymbolsByGradeObjectRequest );
		void GetGradeSymbolsByGradeObjectAsync( GetGradeSymbolsByGradeObjectRequest GetGradeSymbolsByGradeObjectRequest );
		void GetGradeSymbolsByGradeObjectAsync( GetGradeSymbolsByGradeObjectRequest GetGradeSymbolsByGradeObjectRequest, object userState );
		event GetGradeSymbolsByGradeObjectCompletedEventHandler GetGradeSymbolsByGradeObjectCompleted;
		GetGradeSymbolsByUserOrgUnitResponse GetGradeSymbolsByUserOrgUnit( GetGradeSymbolsByUserOrgUnitRequest GetGradeSymbolsByUserOrgUnitRequest );
		void GetGradeSymbolsByUserOrgUnitAsync( GetGradeSymbolsByUserOrgUnitRequest GetGradeSymbolsByUserOrgUnitRequest, object userState );
		void GetGradeSymbolsByUserOrgUnitAsync( GetGradeSymbolsByUserOrgUnitRequest GetGradeSymbolsByUserOrgUnitRequest );
		event GetGradeSymbolsByUserOrgUnitCompletedEventHandler GetGradeSymbolsByUserOrgUnitCompleted;
		GetGradeValuesByUserGradeObjectResponse GetGradeValuesByUserGradeObject( GetGradeValuesByUserGradeObjectRequest GetGradeValuesByUserGradeObjectRequest );
		void GetGradeValuesByUserGradeObjectAsync( GetGradeValuesByUserGradeObjectRequest GetGradeValuesByUserGradeObjectRequest );
		void GetGradeValuesByUserGradeObjectAsync( GetGradeValuesByUserGradeObjectRequest GetGradeValuesByUserGradeObjectRequest, object userState );
		event GetGradeValuesByUserGradeObjectCompletedEventHandler GetGradeValuesByUserGradeObjectCompleted;
		GetGradeValuesWithUserInfoByGradeObjectResponse GetGradeValuesWithUserInfoByGradeObject( GetGradeValuesWithUserInfoByGradeObjectRequest GetGradeValuesWithUserInfoByGradeObjectRequest );
		void GetGradeValuesWithUserInfoByGradeObjectAsync( GetGradeValuesWithUserInfoByGradeObjectRequest GetGradeValuesWithUserInfoByGradeObjectRequest, object userState );
		void GetGradeValuesWithUserInfoByGradeObjectAsync( GetGradeValuesWithUserInfoByGradeObjectRequest GetGradeValuesWithUserInfoByGradeObjectRequest );
		event GetGradeValuesWithUserInfoByGradeObjectCompletedEventHandler GetGradeValuesWithUserInfoByGradeObjectCompleted;
		GetSelectBoxGradeItemResponse GetSelectBoxGradeItem( GetSelectBoxGradeItemRequest GetSelectBoxGradeItemRequest );
		void GetSelectBoxGradeItemAsync( GetSelectBoxGradeItemRequest GetSelectBoxGradeItemRequest, object userState );
		void GetSelectBoxGradeItemAsync( GetSelectBoxGradeItemRequest GetSelectBoxGradeItemRequest );
		event GetSelectBoxGradeItemCompletedEventHandler GetSelectBoxGradeItemCompleted;
		GetStatisticsByGradeObjectResponse GetStatisticsByGradeObject( GetStatisticsByGradeObjectRequest GetStatisticsByGradeObjectRequest );
		void GetStatisticsByGradeObjectAsync( GetStatisticsByGradeObjectRequest GetStatisticsByGradeObjectRequest, object userState );
		void GetStatisticsByGradeObjectAsync( GetStatisticsByGradeObjectRequest GetStatisticsByGradeObjectRequest );
		event GetStatisticsByGradeObjectCompletedEventHandler GetStatisticsByGradeObjectCompleted;
		SetGradeValueResponse SetSelectBoxGradeValue( SetSelectBoxGradeValueRequest SetSelectBoxGradeValueRequest );
		void SetSelectBoxGradeValueAsync( SetSelectBoxGradeValueRequest SetSelectBoxGradeValueRequest, object userState );
		void SetSelectBoxGradeValueAsync( SetSelectBoxGradeValueRequest SetSelectBoxGradeValueRequest );
		event SetSelectBoxGradeValueCompletedEventHandler SetSelectBoxGradeValueCompleted;
		UpdateGradeItemResponse UpdateNumericGradeItem( UpdateNumericGradeItemRequest UpdateNumericGradeItemRequest );
		void UpdateNumericGradeItemAsync( UpdateNumericGradeItemRequest UpdateNumericGradeItemRequest );
		void UpdateNumericGradeItemAsync( UpdateNumericGradeItemRequest UpdateNumericGradeItemRequest, object userState );
		event UpdateNumericGradeItemCompletedEventHandler UpdateNumericGradeItemCompleted;
		UpdateGradeItemResponse UpdatePassFailGradeItem( UpdatePassFailGradeItemRequest UpdatePassFailGradeItemRequest );
		void UpdatePassFailGradeItemAsync( UpdatePassFailGradeItemRequest UpdatePassFailGradeItemRequest );
		void UpdatePassFailGradeItemAsync( UpdatePassFailGradeItemRequest UpdatePassFailGradeItemRequest, object userState );
		event UpdatePassFailGradeItemCompletedEventHandler UpdatePassFailGradeItemCompleted;
		UpdateGradeItemResponse UpdateSelectBoxGradeItem( UpdateSelectBoxGradeItemRequest UpdateSelectBoxGradeItemRequest );
		void UpdateSelectBoxGradeItemAsync( UpdateSelectBoxGradeItemRequest UpdateSelectBoxGradeItemRequest );
		void UpdateSelectBoxGradeItemAsync( UpdateSelectBoxGradeItemRequest UpdateSelectBoxGradeItemRequest, object userState );
		event UpdateSelectBoxGradeItemCompletedEventHandler UpdateSelectBoxGradeItemCompleted;
		UpdateGradeItemResponse UpdateTextGradeItem( UpdateTextGradeItemRequest UpdateTextGradeItemRequest );
		void UpdateTextGradeItemAsync( UpdateTextGradeItemRequest UpdateTextGradeItemRequest, object userState );
		void UpdateTextGradeItemAsync( UpdateTextGradeItemRequest UpdateTextGradeItemRequest );
		event UpdateTextGradeItemCompletedEventHandler UpdateTextGradeItemCompleted;
	}
}
