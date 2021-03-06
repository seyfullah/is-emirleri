import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { throwError } from 'rxjs';
import { Observable } from 'rxjs';

import { catchError, retry } from 'rxjs/operators';

@Injectable()
export class BusinessOrderService {
  constructor(private http: HttpClient) { }
  //businessOrdersUrl = 'http://localhost:5000/api/businessorders';
  businessOrdersTableUrl = 'http://localhost:5000/api/businessorders/table';

  // public getBusinessOrderReport(): Observable<string> {
  //   const headers = new HttpHeaders({ 'Content-Type': 'text/plain' });
  //   return this.http.get(this.businessOrdersUrl, { responseType: 'text', headers })
  //     .pipe(
  //       catchError(this.handleError)
  //     );
  // }

  public getBusinessOrderReportTable(): Observable<string> {
    const headers = new HttpHeaders({ 'Content-Type': 'text/plain' });
    return this.http.get(this.businessOrdersTableUrl, { responseType: 'text', headers })
      .pipe(
        catchError(this.handleError)
      );
  }
  private handleError(error: HttpErrorResponse) {
    if (error.error instanceof ErrorEvent) {
      // A client-side or network error occurred. Handle it accordingly.
      console.error('An error occurred:', error.error.message);
    } else {
      // The backend returned an unsuccessful response code.
      // The response body may contain clues as to what went wrong,
      console.error(
        `Backend returned code ${error.status}, ` +
        `body was: ${error.error}`);
    }
    // return an observable with a user-facing error message
    return throwError(
      'Something bad happened; please try again later.');
  };
}