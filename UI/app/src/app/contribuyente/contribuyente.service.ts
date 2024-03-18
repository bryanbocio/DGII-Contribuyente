import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/enviroment/enviroment';
import { Pagination } from '../shared/models/pagination';
import { IContribuyente } from '../shared/models/contribuyente.type';

@Injectable({
  providedIn: 'root'
})
export class ContribuyenteService {

  constructor(private http: HttpClient) { }

  getContribuyentes=()=>{
    return this.http.get<Pagination<IContribuyente[]>>(environment.API_URL.concat('contribuyentes'));
  }
}
