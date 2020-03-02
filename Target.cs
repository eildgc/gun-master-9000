using System;

namespace gun_master_9000 {
    //No tiene que ver conuna interface visual.
    //Esta interface te permite decir que es lo que deberia de tener sin decir el como
    //A todos los targets les puedes disparar y revisar si estan muertos
    interface Target{
        void Shot ();
        bool IsDead();

    }
}