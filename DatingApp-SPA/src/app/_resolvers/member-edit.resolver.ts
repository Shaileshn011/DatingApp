import { Injectable } from '@angular/core';
import { Resolve, Router, ActivatedRouteSnapshot } from '@angular/router';
import {User} from '../_models/user';
import { from, Observable, of } from 'rxjs';
import { UserService } from '../_services/user.service';
import { AlertifyService } from '../_services/alertify.service';
import { AuthService } from '../_services/auth.service';
import { catchError } from 'rxjs/operators';

@Injectable()

export class MemberEditResolver implements Resolve<User> {
    constructor(private userService: UserService, private alertify: AlertifyService,
                private router: Router, private authService: AuthService) {}

    resolve(route: ActivatedRouteSnapshot): Observable<User> {
        return this.userService.getUser(this.authService.decodedToken.nameid).pipe(
            catchError(error => {
                this.alertify.error(error);
                this.router.navigate(['/members']);
                return of(null);
            })
        );
    }
}
