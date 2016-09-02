using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloXamarin.Location
{
    // definisce i metodi da implementare in ogni piattaforma per ottenere la posizione corrente dell'utente.
    public interface ILocationProvider
    {
        // metodo per gestire i cambi di posizione quando un nuovo LocationPoint è disponibile
        event EventHandler<LocationPoint> LocationChanged;

        // per iniziare ad ottenere la posizione corrente
        void StartAcquisition();

        // quando l'app viene messa in pausa è necessario fermare la localizzazione
        void StopAcquisition();
    }
}
