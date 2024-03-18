import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Pagination } from '../shared/models/pagination';
import { IComprobanteFiscal } from '../shared/models/comprobante.type';
import { environment } from 'src/enviroment/enviroment';
import { ComprobanteParams } from '../shared/models/comprobante.params';

@Injectable({
  providedIn: 'root'
})
export class ComprobanteService {

  constructor(private http:HttpClient) { }
  
  getComprobantes=(comprobanteParams:ComprobanteParams )=>{
    let params=new HttpParams();

    if(comprobanteParams.contribuyenteId>0) params=params.append('ContribuyenteId',comprobanteParams.contribuyenteId);

    return this.http.get<Pagination<IComprobanteFiscal[]>>(environment.API_URL.concat('comprobante-fiscal'), {params});
  }
}
