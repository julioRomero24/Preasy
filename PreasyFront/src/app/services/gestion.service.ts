import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class GestionService {

  constructor(private http: HttpClient) { }

  url: string = "https://localhost:7046/api/gestion/";

  getArea(): Observable<any>{
    return this.http.get(this.url + "area");
  }

  getTurno(): Observable<any>{
    return this.http.get(this.url + "turno");
  }

  getJerarquia(): Observable<any>{
    return this.http.get(this.url + "jerarquia");
  }
}
