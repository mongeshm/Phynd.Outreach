/// <reference path="../viewmodels/campaigntype.ts" />
/// <reference path="../app.configuration.ts" />

import { Injectable } from '@angular/core';
import { Http, Response, RequestOptions, Headers } from '@angular/http';
import { Observable } from 'rxjs/Rx';
import { CampaignType } from '../viewmodels/campaigntype';
import * as apiUrl from '../app.configuration';


export class outreachService
{
    constructor(private http: Http) { }
    
    getCampaignTypes(): Observable<CampaignType[]> {
        
        return this.http.get(apiUrl.apiCampaignUrl + '/CampaignType').map(res => res.json());
    }
}
