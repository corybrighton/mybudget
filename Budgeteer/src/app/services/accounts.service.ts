import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { Bank } from '../models/bank';


const site = environment.site + 'banks';
const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
};

@Injectable({
  providedIn: 'root'
})
export class AccountsService {

  constructor(private http: HttpClient) { }

  getAccountFlow(): Observable<any> {
    return this.http.get(site + '/flow', httpOptions);
  }

  getAccounts(): Observable<any> {
    return this.http.get(site, httpOptions);
  }

  addBank(newBank: Bank): Observable<any> {
    return this.http.post<string>(site, newBank, httpOptions)
      .pipe(
        catchError(this.handleError('addBank', newBank))
      );
  }

  editBank(bank: Bank) {
    return this.http.put<string>(site + '/' + bank.ID, bank, httpOptions)
      .pipe(
        catchError(this.handleError('Edit Bank', bank))
      );
  }


  handleError(name: string, object: any): (err: any, caught: Observable<any>) => import('rxjs').ObservableInput<any> {
    console.log(`${name} did not work.`);
    return;
  }
}
