import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class InvestimentoService {
  private baseUrl = 'https://localhost:7217'; 

  constructor(private http: HttpClient) {}

  calcularInvestimento(data: any): Observable<any> {
    const url = `${this.baseUrl}/api/investimentos/calcular`; 
    return this.http.post(url, data);
  }
}
