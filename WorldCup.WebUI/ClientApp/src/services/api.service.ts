import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, tap, map } from 'rxjs/operators';
import { CupTitle } from 'src/model/cupTitle';
import { FootballClub } from 'src/model/footballClub';


const apiCupTitleUrl = 'https://localhost:44386/api/CupsTitles'
var httpOptions = { headers: new HttpHeaders({ "Content-Type": "application/json" }) };

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http: HttpClient) { }

  getCupTitles(): Observable<CupTitle[]> {

    console.log(httpOptions.headers);
    return this.http.get<CupTitle[]>(apiCupTitleUrl, httpOptions)
      .pipe(tap(cupTitle => console.log('Read cup titles')),
        catchError(this.handleError('getCuptTitles', []))
      );
  }

    private handleError<T>(operation = 'operation', result?: T) {
      return (error: any): Observable<T> => {
        console.error(error);
        return of(result as T);
      }
    }
}
