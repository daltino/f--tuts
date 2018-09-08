#if INTERACTIVE
#r "System.Drawing.dll"
#r "System.Windows.Forms.dll"
#else
module AutoProperties
#endif

type Circle() =
     member val Radius = 0.0 with get, set

let c = Circle()
c.Radius <- 99.9
printf "Radius: %f" c.Radius // 99.9


