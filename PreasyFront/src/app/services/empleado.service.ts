import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { EmpleadoDTO } from '../interface/empleado-dto';
import { tap } from 'node:test/reporters';



@Injectable({
  providedIn: 'root'
})
export class EmpleadoService {
  private apiUrl = 'https://localhost:44324/api/empleado';
  
  

  constructor(private http: HttpClient) { }

  getEmpleados(): Observable<any> {
    return this.http.get<any>(this.apiUrl);
  }



  PostEmpleado(empleado: EmpleadoDTO): Observable<any> {
    return this.http.post<any>(this.apiUrl, empleado);
  }
  
  /*GetNameAreaById(idArea: number): Observable<any>{
    return this.http.get<any>(`${this.apiUrl}/${idArea}`);
  }*/

 

  // Otros métodos como updateEmpleado, deleteEmpleado...
}
