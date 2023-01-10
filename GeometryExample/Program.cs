using GeometryExample;

Cylinder c1 = new Cylinder();
c1.Radius = 38.64;
c1.Height = 22.48;
c1.Process();
c1.Result();

Tiger tg = new Tiger();

tg.SetMe("Lion",100);
tg.Show();

Lion l = new Lion();
l.SetMe("Tiger", 200);
l.Show();