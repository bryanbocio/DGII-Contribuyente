import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/enviroment/enviroment';

@Injectable({
  providedIn: 'root'
})
export class ContribuyenteService {

  constructor(private http: HttpClient) { }



  getContribuyentes=()=>{
    return this.http.get(environment.API_URL.concat('contribuyentes'));
  }
}
